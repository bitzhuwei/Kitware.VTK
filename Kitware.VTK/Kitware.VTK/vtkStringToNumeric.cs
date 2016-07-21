using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStringToNumeric : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringToNumeric";

		public new static readonly string MRClassNameKey;

		static vtkStringToNumeric()
		{
			vtkStringToNumeric.MRClassNameKey = "class vtkStringToNumeric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringToNumeric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToNumeric"));
		}

		public vtkStringToNumeric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToNumeric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringToNumeric New()
		{
			vtkStringToNumeric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToNumeric.vtkStringToNumeric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStringToNumeric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStringToNumeric.vtkStringToNumeric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertCellDataOff_01(HandleRef pThis);

		public virtual void ConvertCellDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertCellDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertCellDataOn_02(HandleRef pThis);

		public virtual void ConvertCellDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertCellDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertEdgeDataOff_03(HandleRef pThis);

		public virtual void ConvertEdgeDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertEdgeDataOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertEdgeDataOn_04(HandleRef pThis);

		public virtual void ConvertEdgeDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertEdgeDataOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertFieldDataOff_05(HandleRef pThis);

		public virtual void ConvertFieldDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertFieldDataOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertFieldDataOn_06(HandleRef pThis);

		public virtual void ConvertFieldDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertFieldDataOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertPointDataOff_07(HandleRef pThis);

		public virtual void ConvertPointDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertPointDataOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertPointDataOn_08(HandleRef pThis);

		public virtual void ConvertPointDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertPointDataOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertRowDataOff_09(HandleRef pThis);

		public virtual void ConvertRowDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertRowDataOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertRowDataOn_10(HandleRef pThis);

		public virtual void ConvertRowDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertRowDataOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertVertexDataOff_11(HandleRef pThis);

		public virtual void ConvertVertexDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertVertexDataOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_ConvertVertexDataOn_12(HandleRef pThis);

		public virtual void ConvertVertexDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertVertexDataOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStringToNumeric_GetConvertCellData_13(HandleRef pThis);

		public virtual bool GetConvertCellData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertCellData_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStringToNumeric_GetConvertEdgeData_14(HandleRef pThis);

		public virtual bool GetConvertEdgeData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertEdgeData_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStringToNumeric_GetConvertFieldData_15(HandleRef pThis);

		public virtual bool GetConvertFieldData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertFieldData_15(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStringToNumeric_GetConvertPointData_16(HandleRef pThis);

		public virtual bool GetConvertPointData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertPointData_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStringToNumeric_GetConvertRowData_17(HandleRef pThis);

		public virtual bool GetConvertRowData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertRowData_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStringToNumeric_GetConvertVertexData_18(HandleRef pThis);

		public virtual bool GetConvertVertexData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertVertexData_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStringToNumeric_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStringToNumeric.vtkStringToNumeric_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStringToNumeric_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStringToNumeric.vtkStringToNumeric_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToNumeric_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStringToNumeric NewInstance()
		{
			vtkStringToNumeric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToNumeric.vtkStringToNumeric_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToNumeric_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringToNumeric SafeDownCast(vtkObjectBase o)
		{
			vtkStringToNumeric vtkStringToNumeric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToNumeric.vtkStringToNumeric_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringToNumeric = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringToNumeric.Register(null);
				}
			}
			return vtkStringToNumeric;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_SetConvertCellData_24(HandleRef pThis, byte _arg);

		public virtual void SetConvertCellData(bool _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertCellData_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_SetConvertEdgeData_25(HandleRef pThis, byte b);

		public virtual void SetConvertEdgeData(bool b)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertEdgeData_25(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_SetConvertFieldData_26(HandleRef pThis, byte _arg);

		public virtual void SetConvertFieldData(bool _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertFieldData_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_SetConvertPointData_27(HandleRef pThis, byte _arg);

		public virtual void SetConvertPointData(bool _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertPointData_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_SetConvertRowData_28(HandleRef pThis, byte b);

		public virtual void SetConvertRowData(bool b)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertRowData_28(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToNumeric_SetConvertVertexData_29(HandleRef pThis, byte b);

		public virtual void SetConvertVertexData(bool b)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertVertexData_29(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}
	}
}
