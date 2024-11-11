/*
  * <copyright file="" company="AfterJS">
  *     Copyright (c) 2023 All Rights Reserved
  * </copyright>
  * <author>Ricardo Amaro</author>
  * <email>a26004@alunos.ipca.pt</email>
  * <date>Tuesday, November 14, 2023</date>
  * <description></description>
*/
   

using System;

namespace MedSync_RM
{
    
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Tuesday, November 14, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public enum BedType
    {
        ICU,
        Regular,
        Obstretic,
        Orthopedic
    }

    public enum BedPosition
    {
        A1,
        A2,
        A3
    }
 
    public class Bed
    {
        #region Attributes

        private Guid id;
        private BedType type;
        private bool isAvailable;
        private Guid patientId;
        private BedPosition position;

        #endregion
        

        #region Methods

        #region Constructors

        public Bed(BedType type, bool isAvaiable, Guid patienId, BedPosition position) // create a bed with patient
        {
            this.id = System.Guid.NewGuid();
            this.type = type;
            this.isAvailable = isAvaiable;
            this.patientId = patienId;
            this.position = position;
        }
        
        public Bed(BedType type, bool isAvaiable, BedPosition position) //create bed without patient
        {
            this.id = System.Guid.NewGuid();
            this.type = type;
            this.isAvailable = isAvaiable;
            this.position = position;
        }
        #endregion

        #region Properties
        
        public Guid Id
        {
            get => id; 
            set => id = value; 
        }
        
        public BedType Type
        {
            get => type; 
            set => type = value; 
        }

     
        public bool IsAvailable
        {
            get => isAvailable; 
            set => isAvailable = value; 
        }

      
        public Guid PatientId
        {
            get => patientId; 
            set => patientId = value; 
        }

        
        public BedPosition Position
        {
            get => position; 
            set => position = value; 
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