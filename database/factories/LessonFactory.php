<?php

namespace Database\Factories;

use App\Models\Course;
use Illuminate\Database\Eloquent\Factories\Factory;

class LessonFactory extends Factory
{
    public function definition(): array
    {
        return [
            'title' => fake()->sentence(4),
            'content' => fake()->paragraphs(3, true),
            'course_id' => Course::factory(),
            'order' => fake()->numberBetween(1, 20),
        ];
    }
}