<?php

namespace App\Filament\Resources\VideoResource\Pages;

use App\Filament\Resources\VideoResource;
use Filament\Resources\Pages\CreateRecord;

class CreateVideo extends CreateRecord
{
    protected static string $resource = VideoResource::class;

    protected function getFormSchema(): array
    {
        return static::$resource::getFormSchema();
    }
}