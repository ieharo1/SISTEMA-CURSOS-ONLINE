# 🏫 Plataforma de Cursos Online (LMS)

Proyecto desarrollado por **Isaac Esteban Haro Torres**.

---

## 📝 Descripción

Sistema completo de gestión de cursos online (LMS). Plataforma profesional para la administración de cursos, lecciones, videos e inscripciones de estudiantes.

### ¿Qué hace este proyecto?

- **Gestión de Cursos**: Crear, editar y publicar cursos
- **Lecciones**: Organización de contenido por lecciones
- **Videos**: Subida y gestión de videos por lección
- **Inscripciones**: Registro de estudiantes en cursos
- **Dashboard**: Métricas de usuarios registrados, cursos activos e inscripciones

---

## ✨ Características Principales

| Característica | Descripción |
|----------------|-------------|
| 📚 **Cursos** | Crear y gestionar cursos |
| 📖 **Lecciones** | Lecciones organizadas por curso |
| 🎥 **Videos** | Videos asociados a lecciones |
| 👥 **Estudiantes** | Gestión de inscripciones |
| 📊 **Dashboard** | Métricas y estadísticas |
| 🔐 **Panel Admin** | Acceso con Filament 3 |

---

## 🛠️ Stack Tecnológico

- **Backend**: PHP 8.2, Laravel 11, Filament 3
- **Frontend**: HTML5, Tailwind CSS (Filament)
- **Base de datos**: MySQL/MariaDB
- **Infraestructura**: Docker, Docker Compose, Nginx

---

## 🚀 Instalación y Uso

### Requisitos

- PHP 8.2+
- Composer
- MySQL/MariaDB
- Docker

### Instalación desde cero

```bash
# Clonar el repositorio
git clone <repositorio>

# Instalar dependencias
composer install

# Copiar archivo de entorno
cp .env.example .env

# Generar clave de aplicación
php artisan key:generate

# Ejecutar migraciones
php artisan migrate

# Poblar base de datos con datos de ejemplo
php artisan db:seed

# Iniciar servidor
php artisan serve
```

### Usar Docker

```bash
# Construir y levantar contenedores
docker compose up -d --build

# Ver estado de los contenedores
docker compose ps

# Acceder al contenedor
docker compose exec app bash

# Ejecutar migraciones dentro del contenedor
php artisan migrate

# Poblar base de datos
php artisan db:seed

# Ver logs
docker compose logs -f app
```

### Credenciales por defecto

| Rol | Email | Contraseña |
|-----|-------|------------|
| Administrador | admin@lms.com | password |
| Instructor | instructor@lms.com | password |

---

## 📁 Estructura del Proyecto

```
├── app/
│   ├── Filament/           # Recursos de Filament
│   │   ├── Resources/      # Recursos (CRUD)
│   │   └── Providers/      # Proveedores de Panel
│   └── Models/             # Modelos Eloquent
├── database/
│   ├── migrations/         # Migraciones
│   ├── seeders/            # Seeders
│   └── factories/          #Factories
├── docker-compose.yml      # Docker Compose
├── Dockerfile              # Configuración Docker
└── nginx.conf              # Configuración Nginx
```

---

## 📊 Módulos del Sistema

1. **Dashboard**: Usuarios, cursos activos, inscripciones
2. **Cursos**: CRUD de cursos
3. **Lecciones**: CRUD de lecciones
4. **Videos**: CRUD de videos
5. **Inscripciones**: Gestión de estudiantes

---

## ⚠️ Requisitos del Sistema

- PHP 8.2 o superior
- Composer
- MySQL 8.0 o MariaDB
- Docker

---

## 👨‍💻 Desarrollado por Isaac Esteban Haro Torres

**Ingeniero en Sistemas · Full Stack · Automatización · Data**

- 📧 Email: zackharo1@gmail.com
- 📱 WhatsApp: 098805517
- 💻 GitHub: https://github.com/ieharo1
- 🌐 Portafolio: https://ieharo1.github.io/portafolio-isaac.haro/

---

© 2026 Isaac Esteban Haro Torres - Todos los derechos reservados.