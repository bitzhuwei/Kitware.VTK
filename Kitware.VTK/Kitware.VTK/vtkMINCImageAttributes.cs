using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMINCImageAttributes : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageAttributes";

		public new static readonly string MRClassNameKey;

		static vtkMINCImageAttributes()
		{
			vtkMINCImageAttributes.MRClassNameKey = "class vtkMINCImageAttributes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMINCImageAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageAttributes"));
		}

		public vtkMINCImageAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMINCImageAttributes New()
		{
			vtkMINCImageAttributes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMINCImageAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMINCImageAttributes.vtkMINCImageAttributes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_AddDimension_01(HandleRef pThis, string dimension);

		public virtual void AddDimension(string dimension)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_AddDimension_01(base.GetCppThis(), dimension);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_AddDimension_02(HandleRef pThis, string dimension, long length);

		public virtual void AddDimension(string dimension, long length)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_AddDimension_02(base.GetCppThis(), dimension, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_FindImageRange_03(HandleRef pThis, IntPtr range);

		public virtual void FindImageRange(IntPtr range)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_FindImageRange_03(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_FindValidRange_04(HandleRef pThis, IntPtr range);

		public virtual void FindValidRange(IntPtr range)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_FindValidRange_04(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetAttributeNames_05(HandleRef pThis, string variable, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetAttributeNames(string variable)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeNames_05(base.GetCppThis(), variable, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetAttributeValueAsArray_06(HandleRef pThis, string variable, string attribute, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetAttributeValueAsArray(string variable, string attribute)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeValueAsArray_06(base.GetCppThis(), variable, attribute, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMINCImageAttributes_GetAttributeValueAsDouble_07(HandleRef pThis, string variable, string attribute);

		public virtual double GetAttributeValueAsDouble(string variable, string attribute)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeValueAsDouble_07(base.GetCppThis(), variable, attribute);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageAttributes_GetAttributeValueAsInt_08(HandleRef pThis, string variable, string attribute);

		public virtual int GetAttributeValueAsInt(string variable, string attribute)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeValueAsInt_08(base.GetCppThis(), variable, attribute);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetAttributeValueAsString_09(HandleRef pThis, string variable, string attribute);

		public virtual string GetAttributeValueAsString(string variable, string attribute)
		{
			return Marshal.PtrToStringAnsi(vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeValueAsString_09(base.GetCppThis(), variable, attribute));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageAttributes_GetDataType_10(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetDataType_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetDimensionLengths_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIdTypeArray GetDimensionLengths()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetDimensionLengths_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetDimensionNames_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetDimensionNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetDimensionNames_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetImageMax_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDoubleArray GetImageMax()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetImageMax_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetImageMin_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDoubleArray GetImageMin()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetImageMin_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetName_15(HandleRef pThis);

		public virtual string GetName()
		{
			return Marshal.PtrToStringAnsi(vtkMINCImageAttributes.vtkMINCImageAttributes_GetName_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageAttributes_GetNumberOfImageMinMaxDimensions_16(HandleRef pThis);

		public virtual int GetNumberOfImageMinMaxDimensions()
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetNumberOfImageMinMaxDimensions_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageAttributes_GetValidateAttributes_17(HandleRef pThis);

		public virtual int GetValidateAttributes()
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetValidateAttributes_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_GetVariableNames_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetVariableNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetVariableNames_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageAttributes_HasAttribute_19(HandleRef pThis, string variable, string attribute);

		public virtual int HasAttribute(string variable, string attribute)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_HasAttribute_19(base.GetCppThis(), variable, attribute);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageAttributes_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageAttributes_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMINCImageAttributes NewInstance()
		{
			vtkMINCImageAttributes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_PrintFileHeader_24(HandleRef pThis);

		public virtual void PrintFileHeader()
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_PrintFileHeader_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_Reset_25(HandleRef pThis);

		public virtual void Reset()
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_Reset_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageAttributes_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMINCImageAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkMINCImageAttributes vtkMINCImageAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageAttributes = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageAttributes.Register(null);
				}
			}
			return vtkMINCImageAttributes;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetAttributeValueAsArray_27(HandleRef pThis, string variable, string attribute, HandleRef array);

		public virtual void SetAttributeValueAsArray(string variable, string attribute, vtkDataArray array)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetAttributeValueAsArray_27(base.GetCppThis(), variable, attribute, (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetAttributeValueAsDouble_28(HandleRef pThis, string variable, string attribute, double value);

		public virtual void SetAttributeValueAsDouble(string variable, string attribute, double value)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetAttributeValueAsDouble_28(base.GetCppThis(), variable, attribute, value);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetAttributeValueAsInt_29(HandleRef pThis, string variable, string attribute, int value);

		public virtual void SetAttributeValueAsInt(string variable, string attribute, int value)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetAttributeValueAsInt_29(base.GetCppThis(), variable, attribute, value);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetAttributeValueAsString_30(HandleRef pThis, string variable, string attribute, string value);

		public virtual void SetAttributeValueAsString(string variable, string attribute, string value)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetAttributeValueAsString_30(base.GetCppThis(), variable, attribute, value);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetDataType_31(HandleRef pThis, int _arg);

		public virtual void SetDataType(int _arg)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetDataType_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetImageMax_32(HandleRef pThis, HandleRef imageMax);

		public virtual void SetImageMax(vtkDoubleArray imageMax)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetImageMax_32(base.GetCppThis(), (imageMax == null) ? default(HandleRef) : imageMax.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetImageMin_33(HandleRef pThis, HandleRef imageMin);

		public virtual void SetImageMin(vtkDoubleArray imageMin)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetImageMin_33(base.GetCppThis(), (imageMin == null) ? default(HandleRef) : imageMin.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetName_34(HandleRef pThis, string _arg);

		public virtual void SetName(string _arg)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetName_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetNumberOfImageMinMaxDimensions_35(HandleRef pThis, int _arg);

		public virtual void SetNumberOfImageMinMaxDimensions(int _arg)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetNumberOfImageMinMaxDimensions_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_SetValidateAttributes_36(HandleRef pThis, int _arg);

		public virtual void SetValidateAttributes(int _arg)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetValidateAttributes_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_ShallowCopy_37(HandleRef pThis, HandleRef source);

		public virtual void ShallowCopy(vtkMINCImageAttributes source)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_ShallowCopy_37(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageAttributes_ValidateAttribute_38(HandleRef pThis, string varname, string attname, HandleRef array);

		public virtual int ValidateAttribute(string varname, string attname, vtkDataArray array)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_ValidateAttribute_38(base.GetCppThis(), varname, attname, (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_ValidateAttributesOff_39(HandleRef pThis);

		public virtual void ValidateAttributesOff()
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_ValidateAttributesOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageAttributes_ValidateAttributesOn_40(HandleRef pThis);

		public virtual void ValidateAttributesOn()
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_ValidateAttributesOn_40(base.GetCppThis());
		}
	}
}
