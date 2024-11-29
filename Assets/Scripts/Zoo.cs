using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Zoo : MonoBehaviour
{
    public List<Animal> animals;
    void Start()
    {
        animals = new List<Animal>() {new Bird(), new Dog(), new Elephant()};
        foreach (Animal a in animals)
        {
            a.Move();
            a.Eat();
        }
    }
}
public abstract class Animal
{
    public abstract void Move();
    public void Eat() { Debug.Log("Njam Njam"); }
}
public class Bird : Animal
{
    public override void Move()
    {
        Debug.Log("flaps its wings");
    }
}
public class Dog : Animal
{
    public override void Move()
    {
        Debug.Log("walks on four legs");
    }
}
public class Elephant : Animal
{
    public override void Move()
    {
        Debug.Log("stomps around an swayes trunk");
    }
}