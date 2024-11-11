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
    /// Purpose: Cost
    /// Created by: João Ferreira
    /// Created on: 15/11/2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Cost
    {
        #region Attributes

        private Guid id;
        private string nameProduct;
        private string description;
        private float basePrice;
        private float vat;

        #endregion

        #region Methods

        #region Constructors

        public Cost(string nameProduct, string description, float basePrice, float vat)
        {
            this.id = System.Guid.NewGuid();
            this.nameProduct = nameProduct;
            this.description = description;
            this.basePrice = basePrice;
            this.vat = vat;
        }

        #endregion

        #region Properties
        public Guid Id
        {
            get => id;
            set => id = value;
        }

        public string NameProduct
        {
            get => nameProduct;
            set => nameProduct = value;
        }
        
        public string Description
        {
            get => description;
            set => description = value;
        }

        public float BasePrice
        {
            get => basePrice;
            set => basePrice = value;
        }

        public float Vat
        {
            get => vat;
            set => vat = value;
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