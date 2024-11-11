/*
  * <copyright file="" company="AfterJS">
  *     Copyright (c) 2023 All Rights Reserved
  * </copyright>
  * <author>Ricardo Amaro</author>
  * <email>a26004@alunos.ipca.pt</email>
  * <date>Wednesday, November 15, 2023</date>
  * <description></description>
*/

using System;
using System.Collections.Generic;

namespace MedSync_RM
{
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Wednesday, November 15, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class Appointment
    {
        #region Attributes

        private Guid id;
        private Guid patientId;
        private Guid medicalProfessionalId;
        private string reason;
        private string room;
        private DateTime date;
        private List<Exam> exams;


        #endregion

        #region Methods

        #region Constructors
        public Appointment(Guid patientId, Guid medicalProfessionalId, string reason, string room, DateTime date)
        {
            this.id = System.Guid.NewGuid();
            this.patientId = patientId;
            MedicalProfessionalId = medicalProfessionalId;
            Reason = reason;
            this.room = room;
            this.date = date;
        }

        public Appointment(Guid patientId, Guid medicalProfessionalId, string reason, string room, DateTime date, List<Exam> exams)
        {
            this.patientId = patientId;
            this.medicalProfessionalId = medicalProfessionalId;
            this.reason = reason;
            this.room = room;
            this.date = date;
            this.exams = exams;
        }

        #endregion

     
        #region Properties

        public Guid Id
        {
            get => id;
            set => id = value;
        }

        public Guid PatientId
        {
            get => patientId;
            set => patientId = value;
        }

        public Guid MedicalProfessionalId
        {
            get => medicalProfessionalId;
            set => medicalProfessionalId = value;
        }

        public string Reason
        {
            get => reason;
            set => reason = value;
        }

        public string Room
        {
            get => room;
            set => room = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        #endregion

        #region Operators

        #endregion

        #region Overrides

        #endregion

        #region Other_Methods

        #endregion

        #endregion
    }
}