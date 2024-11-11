/*
  * <copyright file="" company="AfterJS">
  *     Copyright (c) 2023 All Rights Reserved
  * </copyright>
  * <author>Ricardo Amaro</author>
  * <email>a26004@alunos.ipca.pt</email>
  * <date>Wednesday, November 15, 2023</date>
  * <description></description>
*/

using System.Collections.Generic;

using MedSync_RM_Person;
using MedSync_RM_Address;

namespace MedSync_RM
{
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Wednesday, November 15, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class PersonManager<T> where T : Person
    {
        #region Attributes
        private List<T> personsList;
        #endregion

        #region Methods

        #region Constructors
        
        public PersonManager()
        {
            personsList = new List<T>();
        }

        #endregion

        #region Properties

        public List<T> PersonsList
        {
            get => personsList;
            set => personsList = value;
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