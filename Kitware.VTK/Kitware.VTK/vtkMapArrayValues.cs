using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMapArrayValues : vtkPassInputTypeAlgorithm
	{
		public enum FieldType
		{
			CELL_DATA = 1,
			EDGE_DATA = 3,
			NUM_ATTRIBUTE_LOCS = 5,
			POINT_DATA = 0,
			ROW_DATA = 4,
			VERTEX_DATA = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkMapArrayValues";

		public new static readonly string MRClassNameKey;

		static vtkMapArrayValues()
		{
			vtkMapArrayValues.MRClassNameKey = "class vtkMapArrayValues";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMapArrayValues.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapArrayValues"));
		}

		public vtkMapArrayValues(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapArrayValues_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMapArrayValues New()
		{
			vtkMapArrayValues result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapArrayValues.vtkMapArrayValues_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMapArrayValues() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMapArrayValues.vtkMapArrayValues_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_AddToMap_01(HandleRef pThis, int from, int to);

		public void AddToMap(int from, int to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_01(base.GetCppThis(), from, to);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_AddToMap_02(HandleRef pThis, int from, string to);

		public void AddToMap(int from, string to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_02(base.GetCppThis(), from, to);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_AddToMap_03(HandleRef pThis, string from, int to);

		public void AddToMap(string from, int to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_03(base.GetCppThis(), from, to);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_AddToMap_04(HandleRef pThis, string from, string to);

		public void AddToMap(string from, string to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_04(base.GetCppThis(), from, to);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_ClearMap_05(HandleRef pThis);

		public void ClearMap()
		{
			vtkMapArrayValues.vtkMapArrayValues_ClearMap_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapArrayValues_GetFieldType_06(HandleRef pThis);

		public virtual int GetFieldType()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetFieldType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkMapArrayValues_GetFillValue_07(HandleRef pThis);

		public virtual double GetFillValue()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetFillValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapArrayValues_GetInputArrayName_08(HandleRef pThis);

		public virtual string GetInputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkMapArrayValues.vtkMapArrayValues_GetInputArrayName_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapArrayValues_GetMapSize_09(HandleRef pThis);

		public int GetMapSize()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetMapSize_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapArrayValues_GetOutputArrayName_10(HandleRef pThis);

		public virtual string GetOutputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkMapArrayValues.vtkMapArrayValues_GetOutputArrayName_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapArrayValues_GetOutputArrayType_11(HandleRef pThis);

		public virtual int GetOutputArrayType()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetOutputArrayType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapArrayValues_GetPassArray_12(HandleRef pThis);

		public virtual int GetPassArray()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetPassArray_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapArrayValues_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMapArrayValues.vtkMapArrayValues_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapArrayValues_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMapArrayValues.vtkMapArrayValues_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapArrayValues_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMapArrayValues NewInstance()
		{
			vtkMapArrayValues result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapArrayValues.vtkMapArrayValues_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_PassArrayOff_17(HandleRef pThis);

		public virtual void PassArrayOff()
		{
			vtkMapArrayValues.vtkMapArrayValues_PassArrayOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_PassArrayOn_18(HandleRef pThis);

		public virtual void PassArrayOn()
		{
			vtkMapArrayValues.vtkMapArrayValues_PassArrayOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapArrayValues_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMapArrayValues SafeDownCast(vtkObjectBase o)
		{
			vtkMapArrayValues vtkMapArrayValues = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapArrayValues.vtkMapArrayValues_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapArrayValues = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapArrayValues.Register(null);
				}
			}
			return vtkMapArrayValues;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_SetFieldType_20(HandleRef pThis, int _arg);

		public virtual void SetFieldType(int _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetFieldType_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_SetFillValue_21(HandleRef pThis, double _arg);

		public virtual void SetFillValue(double _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetFillValue_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_SetInputArrayName_22(HandleRef pThis, string _arg);

		public virtual void SetInputArrayName(string _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetInputArrayName_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_SetOutputArrayName_23(HandleRef pThis, string _arg);

		public virtual void SetOutputArrayName(string _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetOutputArrayName_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_SetOutputArrayType_24(HandleRef pThis, int _arg);

		public virtual void SetOutputArrayType(int _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetOutputArrayType_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapArrayValues_SetPassArray_25(HandleRef pThis, int _arg);

		public virtual void SetPassArray(int _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetPassArray_25(base.GetCppThis(), _arg);
		}
	}
}
