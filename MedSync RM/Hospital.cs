/*
 * <copyright file="" company="AfterJS">
 *     Copyright (c) 2023 All Rights Reserved
 * </copyright>
 * <author>Ricardo Amaro</author>
 * <email>a26004@alunos.ipca.pt</email>
 * <date>Tuesday, November 14, 2023</date>
 * <description></description>
 */

using MedSync_RM_Person;
using MedSync_RM_Address;

namespace MedSync_RM
{
    
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: Ricardo Amaro
    /// Created on: Tuesday, November 14, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Hospital
    {

        #region Attributes

        private string hospitalName;
        private Address address;
        private string phoneNumber;

        #endregion
        
        #region Methods

        #region Constructors

        public Hospital(string hospitalName, Address address, string phoneNumber)
        {
            this.hospitalName = hospitalName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        #endregion

        #region Properties

        public string HospitalName
        {
            get => hospitalName; 
            set => hospitalName = value; 
        }

     
        public Address Address
        {
            get => address; 
            set => address = value; 
        }

     
        public string PhoneNumber
        {
            get => phoneNumber; 
            set => phoneNumber = value; 
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

