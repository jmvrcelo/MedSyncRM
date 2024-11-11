/*
 * <copyright file="" company="ICPA">
 *     Copyright (c) 2023 All Rights Reserved
 * </copyright>
 * <author>João Ferreira</author>
 * <email>a25986@alunos.ipca.pt</email>
 * <date>Wednesday, November 15, 2023</date>
 * <description></description>
 */


using System.Collections.Generic;


namespace MedSync_RM
{
    /// <summary>
    /// Purpose: MedSync_RM
    /// Created by: João Ferreira
    /// Created on: Wednesday, November 15, 2023
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class Rooms
    {
        #region Attributes
        private List<Room> rooms;
        #endregion

        #region Methods

        #region Constructors

        public Rooms()
        {
            this.rooms = new List<Room>();
        }

        #endregion

        #region Properties

        public List<Room> RoomList
        {
            get => rooms; 
            set => rooms = value ?? new List<Room>(); 
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