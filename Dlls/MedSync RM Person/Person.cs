/*
  * <copyright file="" company="AfterJS">
  *     Copyright (c) 2023 All Rights Reserved
  * </copyright>
  * <author>Ricardo Amaro</author>
  * <email>a26004@alunos.ipca.pt</email>
  * <date>Wednesday, November 15, 2023</date>
  * <description></description>
*/
using MedSync_RM_Address;
using System;

namespace MedSync_RM_Person
{
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Tuesday, November 14, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public enum Sex
    {
        Male,
        Female
    }
    
    
    public class Person
    {
        #region Attributes
        
        private Guid id;
        private string fullName;
        private DateTime dob;
        private string nif;
        private Address address;
        private Sex sex;
        
        #endregion
        
        
        #region Methods

        #region Constructors

        public Person(string fullName, DateTime dob, string nif, Address address, Sex sex)
        {
            this.id = System.Guid.NewGuid();
            this.fullName = fullName;
            this.dob = dob;
            this.nif = nif;
            this.address = address;
            this.sex = sex;
        }

        #endregion

        #region Properties
        
        public Guid Id
        {
            get =>  id; 
            set => id = value; 
        }


        public string FullName
        {
            get =>  fullName; 
            set => fullName = value; 
        }
        public DateTime Dob
        {
            get =>  dob; 
            set => dob = value; 
        }

      
        public string Nif
        {
            get =>  nif; 
            set => nif = value; 
        }
        
        public Address PatientAddress
        {
            get =>  address; 
            set => address = value; 
        }

 
        public Sex Sex
        {
            get =>  sex; 
            set => sex = value; 
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