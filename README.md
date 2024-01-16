# TopSystemGeometricShapes
Библиотека `TopSystemGeometricShapes` предоставляет абстрактный базовый класс `Shape` и несколько конкретных классов, представляющих геометрические фигуры. Каждая фигура реализует метод `Draw()`, который выводит изображение фигуры в консоль.

## Описание классов

### `Shape`

Абстрактный базовый класс, содержащий абстрактный метод `Draw()`, который должен быть реализован в производных классах.

### `Circle`

```csharp
public class Circle(int radius) : Shape
```

Класс представляет круг с заданным радиусом. Метод `Draw()` выводит изображение круга в консоль.

### `Ellipse`

```csharp
public class Ellipse(int semiMajorAxis, int semiMinorAxis) : Shape
```

Класс представляет эллипс с полуосью `semiMajorAxis` и `semiMinorAxis`. Метод `Draw()` выводит изображение эллипса в консоль.

### `Rectangle`

```csharp
public class Rectangle(int sideA, int sideB) : Shape
```

Класс представляет прямоугольник с сторонами `sideA` и `sideB`. Метод `Draw()` выводит изображение прямоугольника в консоль.

### `Square`

```csharp
public class Square(int sideLength) : Shape
```

Класс представляет квадрат со стороной `sideLength`. Метод `Draw()` выводит изображение квадрата в консоль.

### `Triangle`

```csharp
public class Triangle(int rows, TriangleType type) : Shape
```

Класс представляет треугольник с указанным типом (`RightAngle`, `LeftAngle`, `Isosceles`) и количеством строк `rows`. Метод `Draw()` выводит изображение треугольника в консоль.

## Перечисление `TriangleType`

```csharp
public enum TriangleType
{
    RightAngle,
    LeftAngle,
    Isosceles
}
```

Перечисление определяет типы треугольников, которые могут быть использованы при создании экземпляра класса `Triangle`.

## Примеры
### Установка
```csharp
dotnet add package TopSystemGeometricShapes
```

### Использование
#### Создание и отрисовка круга
```csharp
Circle circle = new Circle(5);
circle.Draw();
```

#### Создание и отрисовка эллипса

```csharp
Ellipse ellipse = new Ellipse(4, 2);
ellipse.Draw();
```

#### Создание и отрисовка прямоугольника

```csharp
Rectangle rectangle = new Rectangle(3, 6);
rectangle.Draw();
```

#### Создание и отрисовка квадрата

```csharp
Square square = new Square(4);
square.Draw();
```

#### Создание и отрисовка треугольника

```csharp
Triangle triangle = new Triangle(5, TriangleType.Isosceles);
triangle.Draw();
```

## Примечание

Эта библиотека разработана в качестве тестового задания для IT компании "Топ Системы".

