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
    public class Specialty
    {

        #region Attributes

        private Guid id;
        private string specialtyName;
        
        #endregion
        
        #region Methods

        #region Constructors

        public Specialty(string specialty)
        {
            this.id = System.Guid.NewGuid();
            this.specialtyName = specialty;
        }
        #endregion

        #region Properties

        public string SpecialtyName
        {
            get  => specialtyName;
            set  => specialtyName = value; 
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