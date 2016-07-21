using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIdFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdFilter";

		public new static readonly string MRClassNameKey;

		static vtkIdFilter()
		{
			vtkIdFilter.MRClassNameKey = "class vtkIdFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdFilter"));
		}

		public vtkIdFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIdFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIdFilter New()
		{
			vtkIdFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdFilter.vtkIdFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIdFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIdFilter.vtkIdFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_CellIdsOff_01(HandleRef pThis);

		public virtual void CellIdsOff()
		{
			vtkIdFilter.vtkIdFilter_CellIdsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_CellIdsOn_02(HandleRef pThis);

		public virtual void CellIdsOn()
		{
			vtkIdFilter.vtkIdFilter_CellIdsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_FieldDataOff_03(HandleRef pThis);

		public virtual void FieldDataOff()
		{
			vtkIdFilter.vtkIdFilter_FieldDataOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_FieldDataOn_04(HandleRef pThis);

		public virtual void FieldDataOn()
		{
			vtkIdFilter.vtkIdFilter_FieldDataOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIdFilter_GetCellIds_05(HandleRef pThis);

		public virtual int GetCellIds()
		{
			return vtkIdFilter.vtkIdFilter_GetCellIds_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIdFilter_GetFieldData_06(HandleRef pThis);

		public virtual int GetFieldData()
		{
			return vtkIdFilter.vtkIdFilter_GetFieldData_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIdFilter_GetIdsArrayName_07(HandleRef pThis);

		public virtual string GetIdsArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkIdFilter.vtkIdFilter_GetIdsArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIdFilter_GetPointIds_08(HandleRef pThis);

		public virtual int GetPointIds()
		{
			return vtkIdFilter.vtkIdFilter_GetPointIds_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIdFilter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIdFilter.vtkIdFilter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIdFilter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIdFilter.vtkIdFilter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIdFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIdFilter NewInstance()
		{
			vtkIdFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdFilter.vtkIdFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_PointIdsOff_13(HandleRef pThis);

		public virtual void PointIdsOff()
		{
			vtkIdFilter.vtkIdFilter_PointIdsOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_PointIdsOn_14(HandleRef pThis);

		public virtual void PointIdsOn()
		{
			vtkIdFilter.vtkIdFilter_PointIdsOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIdFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIdFilter SafeDownCast(vtkObjectBase o)
		{
			vtkIdFilter vtkIdFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdFilter.vtkIdFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdFilter = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdFilter.Register(null);
				}
			}
			return vtkIdFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_SetCellIds_16(HandleRef pThis, int _arg);

		public virtual void SetCellIds(int _arg)
		{
			vtkIdFilter.vtkIdFilter_SetCellIds_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_SetFieldData_17(HandleRef pThis, int _arg);

		public virtual void SetFieldData(int _arg)
		{
			vtkIdFilter.vtkIdFilter_SetFieldData_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_SetIdsArrayName_18(HandleRef pThis, string _arg);

		public virtual void SetIdsArrayName(string _arg)
		{
			vtkIdFilter.vtkIdFilter_SetIdsArrayName_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIdFilter_SetPointIds_19(HandleRef pThis, int _arg);

		public virtual void SetPointIds(int _arg)
		{
			vtkIdFilter.vtkIdFilter_SetPointIds_19(base.GetCppThis(), _arg);
		}
	}
}
