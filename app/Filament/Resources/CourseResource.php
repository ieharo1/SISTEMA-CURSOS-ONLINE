<?php

namespace App\Filament\Resources;

use App\Filament\Resources\CourseResource\Pages;
use App\Models\Course;
use Filament\Forms;
use Filament\Forms\Form;
use Filament\Resources\Resource;
use Filament\Tables;
use Filament\Tables\Table;

class CourseResource extends Resource
{
    protected static ?string $model = Course::class;

    protected static ?string $navigationIcon = 'heroicon-o-academic-cap';

    public static function form(Form $form): Form
    {
        return $form
            ->schema([
                Forms\Components\TextInput::make('title')->required(),
                Forms\Components\Textarea::make('description'),
                Forms\Components\TextInput::make('image')->label('URL de imagen'),
                Forms\Components\Select::make('user_id')
                    ->label('Instructor')
                    ->relationship('user', 'name')
                    ->required(),
                Forms\Components\Toggle::make('is_published')->label('Publicado'),
            ]);
    }

    public static function table(Table $table): Table
    {
        return $table
            ->columns([
                Tables\Columns\TextColumn::make('title')->searchable(),
                Tables\Columns\TextColumn::make('user.name')->label('Instructor'),
                Tables\Columns\BooleanColumn::make('is_published')->label('Publicado'),
                Tables\Columns\TextColumn::make('lessons_count')->label('Lecciones')
                    ->counts('lessons'),
                Tables\Columns\TextColumn::make('enrollments_count')->label('Estudiantes')
                    ->counts('enrollments'),
                Tables\Columns\TextColumn::make('created_at')->dateTime(),
            ])
            ->filters([
                Tables\Filters\SelectFilter::make('is_published')
                    ->options([
                        true => 'Publicado',
                        false => 'Borrador',
                    ]),
            ])
            ->actions([
                Tables\Actions\EditAction::make(),
                Tables\Actions\DeleteAction::make(),
            ])
            ->bulkActions([
                Tables\Actions\DeleteBulkAction::make(),
            ]);
    }

    public static function getPages(): array
    {
        return [
            'index' => Pages\ListCourses::route('/'),
            'create' => Pages\CreateCourse::route('/create'),
            'edit' => Pages\EditCourse::route('/{record}/edit'),
        ];
    }
}