﻿namespace CliningContoraFromValera.Bll
{
    public enum StatusType
    {
        Обработка,
        Выполняется,
        Выполнен,
        Отменён,
        Новый,
        Согласован
    }

    public enum ServiceType
    {
        Сухая_уборка,
        Влажная_уборка,
        Мойка_окон,
        Дезинсекция,
        Химчистка,
        Уборка_после_ремонта,
        Генеральная_уборка
    }

    public enum UnitType
    {
        шт,
        м2,
        кг
    }
    public enum ClientOrderType
    {
        Юр_Лицо,
        Физ_Лицо
    }
}
