﻿using System;
using System.Collections.Generic;
using BashSoft.Execptions;
using BashSoft.Models;

namespace BashSoft.Contracts
{
    public interface IStudent
    {
        string Username { get; }

        IReadOnlyDictionary<string, ICourse> EnrolledCourses { get; }

        IReadOnlyDictionary<string, double> MarksByCourseName { get; }

        void EnrollInCourse(ICourse course);

        void SetMarkOnCourse(string courseName, params int[] scores);

    }
}
