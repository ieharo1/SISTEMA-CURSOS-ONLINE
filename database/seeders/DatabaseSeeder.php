<?php

namespace Database\Seeders;

use App\Models\Course;
use App\Models\Enrollment;
use App\Models\Lesson;
use App\Models\User;
use App\Models\Video;
use Illuminate\Database\Seeder;

class DatabaseSeeder extends Seeder
{
    public function run(): void
    {
        $admin = User::factory()->create([
            'name' => 'Admin User',
            'email' => 'admin@lms.com',
            'password' => bcrypt('password'),
        ]);

        $instructor = User::factory()->create([
            'name' => 'Instructor Demo',
            'email' => 'instructor@lms.com',
            'password' => bcrypt('password'),
        ]);

        $students = User::factory(10)->create();

        $courses = Course::factory(5)->create([
            'user_id' => $instructor->id,
        ]);

        foreach ($courses as $course) {
            $lessons = Lesson::factory(3)->create([
                'course_id' => $course->id,
            ]);

            foreach ($lessons as $lesson) {
                Video::factory(2)->create([
                    'lesson_id' => $lesson->id,
                ]);
            }

            foreach ($students->random(5) as $student) {
                Enrollment::factory()->create([
                    'user_id' => $student->id,
                    'course_id' => $course->id,
                ]);
            }
        }
    }
}