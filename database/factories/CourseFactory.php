<?php

namespace Database\Factories;

use App\Models\User;
use Illuminate\Database\Eloquent\Factories\Factory;

class CourseFactory extends Factory
{
    public function definition(): array
    {
        return [
            'title' => fake()->sentence(3),
            'description' => fake()->paragraph(),
            'image' => 'https://picsum.photos/seed/' . fake()->uuid() . '/800/600',
            'user_id' => User::factory(),
            'is_published' => fake()->boolean(),
        ];
    }
}