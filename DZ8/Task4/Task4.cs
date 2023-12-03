using System;

// Завдання 4: Принцип розділення інтерфейсу(ISP) (The Interface Segregation Principle)
interface IDiscount
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface IColor
{
    void SetColor(byte color);
}

interface ISize
{
    void SetSize(byte size);
}

interface IPrice
{
    void SetPrice(double price);
}

// клас книжки (розмір та колір не потрібні, але потрібна ціна та знижки)
class Book: IDiscount, IPrice
{
    public void ApplyDiscount(String discount) { }
    public void ApplyPromocode(String promocode) { }
    public void SetPrice(double price) { }
}

// клас верхній одяг(колір, розмір, ціна, знижка)
class Outerwear: IColor, ISize, IPrice, IDiscount
{
    public void SetColor(byte color) { }
    public void SetSize(byte size) { }
    public void SetPrice(double price) { }
    public void ApplyDiscount(String discount) { }
    public void ApplyPromocode(String promocode) { }
}