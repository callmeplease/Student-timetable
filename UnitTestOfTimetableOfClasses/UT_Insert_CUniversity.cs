﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CUniversity
	{
		/// <summary>
		/// Ввод корректных данных в пустую таблицу
		/// </summary>
		[TestMethod]
		public void Task_496_1()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool expected = true;
			//act 
			bool actual = RefData.CUniversity.Insert(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Краткое название добавляемой группы дублирует Краткое название уже существующей группы
		/// </summary>
		[TestMethod]
		public void Task_496_2()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Технологический Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Полное название добавляемой группы дублирует Полное название уже существующей группы
		/// </summary>
		[TestMethod]
		public void Task_496_3()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Фактический адрес добавляемой группы дублирует Фактический адрес уже существующей группы
		/// </summary>
		[TestMethod]
		public void Task_496_4()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Юридический адрес добавляемой группы дублирует Фактический адрес уже существующей группы
		/// </summary>
		[TestMethod]
		public void Task_496_5()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что ФИО ректора добавляемой группы дублирует ФИО ректора уже существующей группы
		/// </summary>
		[TestMethod]
		public void Task_496_6()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Александр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Почта добавляемой группы дублирует Почта уже существующей группы
		/// </summary>
		[TestMethod]
		public void Task_496_7()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Дмитрий", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Телефон добавляемой группы дублирует Телефон уже существующей группы
		/// </summary>
		[TestMethod]
		public void Task_496_8()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317960");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что ИНН добавляемой группы дублирует ИНН уже существующей группы
		/// </summary>
		[TestMethod]
		public void Task_496_9()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401006286", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод данных аналогичных уже существующим
		/// </summary>
		[TestMethod]
		public void Task_496_10()
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}
