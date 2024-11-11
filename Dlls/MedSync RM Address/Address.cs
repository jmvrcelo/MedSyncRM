/*
  * <copyright file="" company="AfterJS">
  *     Copyright (c) 2023 All Rights Reserved
  * </copyright>
  * <author>Ricardo Amaro</author>
  * <email>a26004@alunos.ipca.pt</email>
  * <date>Wednesday, November 15, 2023</date>
  * <description></description>
*/

namespace MedSync_RM_Address
{
    /// <summary>
    /// Purpose: MedSync_RM_Address
    /// Created by: Ricardo Amaro
    /// Created on: Wednesday, November 15, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class Address
    {
        
        #region Attributes
        
        private string address;
        private string street;
        private string zipCode;
        private string doorNumber;

        #endregion
        
        #region Methods

        #region Constructors
        public Address(string address, string street, string zipCode)
        {
            this.address = address;
            this.street = street;
            this.zipCode = zipCode;
        }
        
        public Address(string address, string street, string zipCode, string doorNumber)
        {
            this.address = address;
            this.street = street;
            this.zipCode = zipCode;
            this.doorNumber = doorNumber;
        }
        
        #endregion

        #region Properties

        public string _Address
        {
            get => address;
            set => address = value;
        }

        public string Street
        {
            get => street;
            set => street = value;
        }

        public string ZipCode
        {
            get => zipCode;
            set => zipCode = value;
        }

        public string DoorNumber
        {
            get => doorNumber;
            set => doorNumber = value;
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