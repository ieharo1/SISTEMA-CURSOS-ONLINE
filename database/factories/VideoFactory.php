<?php

namespace Database\Factories;

use App\Models\Lesson;
use Illuminate\Database\Eloquent\Factories\Factory;

class VideoFactory extends Factory
{
    public function definition(): array
    {
        return [
            'title' => fake()->sentence(3),
            'url' => 'https://www.youtube.com/watch?v=' . fake()->uuid(),
            'lesson_id' => Lesson::factory(),
        ];
    }
}