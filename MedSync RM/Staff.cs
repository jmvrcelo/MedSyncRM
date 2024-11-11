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

namespace MedSync_RM
{
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Wednesday, November 15, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public enum Role
    {
        Rececionist,
        ITSpecialist,
        Accountant,
        Administrator
    }
    public class Staff
    {
        #region Attributes

        private Guid id;
        private Role role;

        #endregion

        #region Methods

        #region Constructors

        public Staff(Role role)
        {
            this.id = System.Guid.NewGuid();
            this.role = role;
        }

        #endregion

        #region Properties
        
        public Guid Id
        {
            get => id;
            set => id = value;
        }

        public Role Role
        {
            get => role;
            set => role = value;
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