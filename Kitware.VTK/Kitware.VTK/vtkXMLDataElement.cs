using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLDataElement : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataElement";

		public new static readonly string MRClassNameKey;

		static vtkXMLDataElement()
		{
			vtkXMLDataElement.MRClassNameKey = "class vtkXMLDataElement";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataElement.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataElement"));
		}

		public vtkXMLDataElement(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLDataElement New()
		{
			vtkXMLDataElement result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLDataElement() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLDataElement.vtkXMLDataElement_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_AddCharacterData_01(HandleRef pThis, string data, uint length);

		public void AddCharacterData(string data, uint length)
		{
			vtkXMLDataElement.vtkXMLDataElement_AddCharacterData_01(base.GetCppThis(), data, length);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_AddNestedElement_02(HandleRef pThis, HandleRef element);

		public void AddNestedElement(vtkXMLDataElement element)
		{
			vtkXMLDataElement.vtkXMLDataElement_AddNestedElement_02(base.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_DeepCopy_03(HandleRef pThis, HandleRef elem);

		public virtual void DeepCopy(vtkXMLDataElement elem)
		{
			vtkXMLDataElement.vtkXMLDataElement_DeepCopy_03(base.GetCppThis(), (elem == null) ? default(HandleRef) : elem.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_FindNestedElement_04(HandleRef pThis, string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement FindNestedElement(string id)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_FindNestedElement_04(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithName_05(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement FindNestedElementWithName(string name)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_FindNestedElementWithName_05(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithNameAndAttribute_06(HandleRef pThis, string name, string att_name, string att_value, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement FindNestedElementWithNameAndAttribute(string name, string att_name, string att_value)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_FindNestedElementWithNameAndAttribute_06(base.GetCppThis(), name, att_name, att_value, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithNameAndId_07(HandleRef pThis, string name, string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement FindNestedElementWithNameAndId(string name, string id)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_FindNestedElementWithNameAndId_07(base.GetCppThis(), name, id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetAttribute_08(HandleRef pThis, string name);

		public string GetAttribute(string name)
		{
			return Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetAttribute_08(base.GetCppThis(), name));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetAttributeEncoding_09(HandleRef pThis);

		public virtual int GetAttributeEncoding()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetAttributeEncoding_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetAttributeEncodingMaxValue_10(HandleRef pThis);

		public virtual int GetAttributeEncodingMaxValue()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetAttributeEncodingMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetAttributeEncodingMinValue_11(HandleRef pThis);

		public virtual int GetAttributeEncodingMinValue()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetAttributeEncodingMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetAttributeName_12(HandleRef pThis, int idx);

		public string GetAttributeName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetAttributeName_12(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetAttributeValue_13(HandleRef pThis, int idx);

		public string GetAttributeValue(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetAttributeValue_13(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetCharacterData_14(HandleRef pThis);

		public virtual string GetCharacterData()
		{
			return Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetCharacterData_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetCharacterDataWidth_15(HandleRef pThis);

		public virtual int GetCharacterDataWidth()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetCharacterDataWidth_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetId_16(HandleRef pThis);

		public virtual string GetId()
		{
			return Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetId_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetName_17(HandleRef pThis);

		public virtual string GetName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetName_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetNestedElement_18(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement GetNestedElement(int index)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_GetNestedElement_18(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetNumberOfAttributes_19(HandleRef pThis);

		public virtual int GetNumberOfAttributes()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetNumberOfAttributes_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetNumberOfNestedElements_20(HandleRef pThis);

		public int GetNumberOfNestedElements()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetNumberOfNestedElements_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetParent_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement GetParent()
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_GetParent_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_GetRoot_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkXMLDataElement GetRoot()
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_GetRoot_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_23(HandleRef pThis, string name, ref int value);

		public int GetScalarAttribute(string name, ref int value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_23(base.GetCppThis(), name, ref value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_24(HandleRef pThis, string name, ref float value);

		public int GetScalarAttribute(string name, ref float value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_24(base.GetCppThis(), name, ref value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_25(HandleRef pThis, string name, ref double value);

		public int GetScalarAttribute(string name, ref double value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_25(base.GetCppThis(), name, ref value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_26(HandleRef pThis, string name, ref uint value);

		public int GetScalarAttribute(string name, ref uint value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_26(base.GetCppThis(), name, ref value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_27(HandleRef pThis, string name, ref long value);

		public int GetScalarAttribute(string name, ref long value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_27(base.GetCppThis(), name, ref value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetVectorAttribute_28(HandleRef pThis, string name, int length, IntPtr value);

		public int GetVectorAttribute(string name, int length, IntPtr value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetVectorAttribute_28(base.GetCppThis(), name, length, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_GetWordTypeAttribute_29(HandleRef pThis, string name, ref int value);

		public int GetWordTypeAttribute(string name, ref int value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetWordTypeAttribute_29(base.GetCppThis(), name, ref value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkXMLDataElement_GetXMLByteIndex_30(HandleRef pThis);

		public virtual uint GetXMLByteIndex()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetXMLByteIndex_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLDataElement.vtkXMLDataElement_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_IsEqualTo_32(HandleRef pThis, HandleRef elem);

		public virtual int IsEqualTo(vtkXMLDataElement elem)
		{
			return vtkXMLDataElement.vtkXMLDataElement_IsEqualTo_32(base.GetCppThis(), (elem == null) ? default(HandleRef) : elem.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLDataElement_IsTypeOf_33(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataElement.vtkXMLDataElement_IsTypeOf_33(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_LookupElement_34(HandleRef pThis, string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement LookupElement(string id)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_LookupElement_34(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_LookupElementWithName_35(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement LookupElementWithName(string name)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_LookupElementWithName_35(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLDataElement NewInstance()
		{
			vtkXMLDataElement result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_NewInstance_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_PrintXML_38(HandleRef pThis, string fname);

		public void PrintXML(string fname)
		{
			vtkXMLDataElement.vtkXMLDataElement_PrintXML_38(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_RemoveAllAttributes_39(HandleRef pThis);

		public virtual void RemoveAllAttributes()
		{
			vtkXMLDataElement.vtkXMLDataElement_RemoveAllAttributes_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_RemoveAllNestedElements_40(HandleRef pThis);

		public virtual void RemoveAllNestedElements()
		{
			vtkXMLDataElement.vtkXMLDataElement_RemoveAllNestedElements_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_RemoveAttribute_41(HandleRef pThis, string name);

		public virtual void RemoveAttribute(string name)
		{
			vtkXMLDataElement.vtkXMLDataElement_RemoveAttribute_41(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_RemoveNestedElement_42(HandleRef pThis, HandleRef arg0);

		public virtual void RemoveNestedElement(vtkXMLDataElement arg0)
		{
			vtkXMLDataElement.vtkXMLDataElement_RemoveNestedElement_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataElement_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLDataElement SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetAttribute_44(HandleRef pThis, string name, string value);

		public void SetAttribute(string name, string value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetAttribute_44(base.GetCppThis(), name, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetAttributeEncoding_45(HandleRef pThis, int _arg);

		public virtual void SetAttributeEncoding(int _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetAttributeEncoding_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetCharacterData_46(HandleRef pThis, string c, int length);

		public void SetCharacterData(string c, int length)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetCharacterData_46(base.GetCppThis(), c, length);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetCharacterDataWidth_47(HandleRef pThis, int _arg);

		public virtual void SetCharacterDataWidth(int _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetCharacterDataWidth_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetDoubleAttribute_48(HandleRef pThis, string name, double value);

		public void SetDoubleAttribute(string name, double value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetDoubleAttribute_48(base.GetCppThis(), name, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetFloatAttribute_49(HandleRef pThis, string name, float value);

		public void SetFloatAttribute(string name, float value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetFloatAttribute_49(base.GetCppThis(), name, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetId_50(HandleRef pThis, string _arg);

		public virtual void SetId(string _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetId_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetIdTypeAttribute_51(HandleRef pThis, string name, long value);

		public void SetIdTypeAttribute(string name, long value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetIdTypeAttribute_51(base.GetCppThis(), name, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetIntAttribute_52(HandleRef pThis, string name, int value);

		public void SetIntAttribute(string name, int value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetIntAttribute_52(base.GetCppThis(), name, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetName_53(HandleRef pThis, string _arg);

		public virtual void SetName(string _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetName_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetParent_54(HandleRef pThis, HandleRef parent);

		public void SetParent(vtkXMLDataElement parent)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetParent_54(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetUnsignedLongAttribute_55(HandleRef pThis, string name, uint value);

		public void SetUnsignedLongAttribute(string name, uint value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetUnsignedLongAttribute_55(base.GetCppThis(), name, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetVectorAttribute_56(HandleRef pThis, string name, int length, IntPtr value);

		public void SetVectorAttribute(string name, int length, IntPtr value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetVectorAttribute_56(base.GetCppThis(), name, length, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLDataElement_SetXMLByteIndex_57(HandleRef pThis, uint _arg);

		public virtual void SetXMLByteIndex(uint _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetXMLByteIndex_57(base.GetCppThis(), _arg);
		}
	}
}
