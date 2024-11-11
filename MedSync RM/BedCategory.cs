/*
*	<copyright file="MedSync RM.cs" company="IPCA">
*	Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>João Ferreira</author>
*   <date>15/11/2023</date>
*	<description></description>
*/

using System;

namespace MedSync_RM
{
    /// <summary>
    /// Purpose: BedCategory
    /// Created by: João Ferreira
    /// Created on: 15/11/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class BedCategory
    {
        #region Attributes

        private Guid id;
        private string categoryName;

        #endregion

        #region Methods

        #region Constructors

        public BedCategory(string categoryName)
        {
            this.id = System.Guid.NewGuid();
            this.categoryName = categoryName;
        }

        #endregion

        #region Properties

        public Guid Id
        {
            get => id;
            set => id = value;
        }

        public string CategoryName
        {
            get => categoryName;
            set => categoryName = value;
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