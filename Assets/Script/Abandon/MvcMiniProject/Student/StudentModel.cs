using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentModel:Basemodel
{
    public string name;
    public int age;
    public string studentNum;
    public int grade;
    public Major major;
    public float averscore;
    public StudentModel(string name, int age, string studentNum, int grade, Major major, float averscore)
    {
        this.name = name;
        this.age = age;
        this.studentNum = studentNum;
        this.grade = grade;
        this.major = major;
        this.averscore = averscore;
    }
    public StudentModel()
    {

    }
    public void Print()
    {
        Debug.Log("姓名为" + name);
        Debug.Log("专业" + major);
    }
    
}

public enum Major
{
    Math, English, Chinese, Geographic, Political, Physical, Chemical, History
}