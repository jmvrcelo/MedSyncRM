/*
 * <copyright file="" company="AfterJS">
 *     Copyright (c) 2023 All Rights Reserved
 * </copyright>
 * <author>Ricardo Amaro</author>
 * <email>a26004@alunos.ipca.pt</email>
 * <author>Jo�o Ferreira</author>
 * <email>a25986@alunos.ipca.pt</email>
 * <date>Tuesday, November 14, 2023</date>
 * <description></description>
 */

using System.Collections.Generic;

namespace MedSync_RM
{
    public class Room
    {
        
        /// <summary>
        /// Purpose: MedSync_RM
        /// Created by: Ricardo Amaro & Jo�o Ferreira
        /// Created on: Tuesday, November 14, 2023
        /// </summary>
        /// <remarks></remarks>
        /// <example></example>

        #region Attributes

        private int id;
        private List<Bed> beds;
        private int maxBeds;
        private int floor;
   
        #endregion



        #region Methods

        #region Constructors

        public Room(List<Bed> beds, int floor)
        {
            this.beds = beds;
            this.floor = floor;
        }

        public Room(List<Bed> beds, int maxBeds, int floor)
        {
            this.beds = beds;
            this.maxBeds = maxBeds;
            this.floor = floor;
        }

        #endregion

        #region Properties

        public int Id
        {
            get => id;
            set => id = value;
        }

        public List<Bed> Beds
        {
            get => beds;
            set => beds = value;
        }

        public int MaxBeds
        {
            get => maxBeds;
            set => maxBeds = value;
        }

        public int Floor
        {
            get => floor;
            set => floor = value;
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