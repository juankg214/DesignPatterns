// See https://aka.ms/new-console-template for more information

using DuckChapter1.Entities;

Duck juan = new MallardDuck();
juan.PerformFly();
juan.PerformQuack();
juan.SetFlyBehaviour(new FlyNoWay());
juan.PerformFly();