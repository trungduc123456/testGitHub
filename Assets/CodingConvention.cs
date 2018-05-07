using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

public class CodingConvention : MonoBehaviour
{
    public FileStream WriteToFile(string path, string text)
    {
        var fs = File.Create(path);
        var bytes = Encoding.UTF8.GetBytes(text);
        fs.Write(bytes, 0, bytes.Length);
        return fs;
    }
    public class Person
    {
        readonly int age;
        readonly string name;
        public Person()
        {

        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
    public StringBuilder bld;
    public List<Person> person;
    private int number;

    public int Number
    {
        get
        {
            return number;
        }

        set
        {
            number = value;
        }
    }
    public bool IsOdd(uint x)
    {
        return x % 2 == 1;
    }
    public bool IsEmpty(List<Person> lst)
    {
        return lst.Any();
    }
    // Use this for initialization
    void Start()
    {
        //bld = new StringBuilder();
        //for (int i = 0; i < 30; i++)
        //{
        //    bld.Append(Convert.ToChar(i));
        //}
        //string str = bld.ToString();
        //Debug.Log(str);
        //str.ToLowerInvariant();
        //Debug.Log(str);
        //if (!string.IsNullOrEmpty(str))
        //{
        //    Debug.Log("Duc");
        //}
        //else
        //{
        //    Debug.Log("Not Duc");
        //}
        //Number = 100;
        //Debug.Log(number);
        person = new List<Person>();
        person.Add(new Person(10, "Duc"));
        person.Add(new Person(11, "Anh"));
        var x = person.Where(person => person.Age > 10).ToList()/*.Select(person => person.age += 10).ToList()*/;
        Debug.Log(x[0].Age);
        var isEqual = "this string".Equals("other string");
        //var x = person.OrderBy(person => person.name).ThenBy(person => person.age).ToList();
        //Debug.Log(IsEmpty(person));
        //Debug.Log(IsOdd(5));
        //var y = person.OfType<Person>().Any(person => person.age > 10);
        //Debug.Log(y);
        //Debug.Log(x[0].name + " " + x[1].name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
