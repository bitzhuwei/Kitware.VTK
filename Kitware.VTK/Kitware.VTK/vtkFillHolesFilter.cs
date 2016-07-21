using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFillHolesFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFillHolesFilter";

		public new static readonly string MRClassNameKey;

		static vtkFillHolesFilter()
		{
			vtkFillHolesFilter.MRClassNameKey = "class vtkFillHolesFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFillHolesFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFillHolesFilter"));
		}

		public vtkFillHolesFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFillHolesFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFillHolesFilter New()
		{
			vtkFillHolesFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFillHolesFilter.vtkFillHolesFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFillHolesFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFillHolesFilter.vtkFillHolesFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkFillHolesFilter_GetHoleSize_01(HandleRef pThis);

		public virtual double GetHoleSize()
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_GetHoleSize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkFillHolesFilter_GetHoleSizeMaxValue_02(HandleRef pThis);

		public virtual double GetHoleSizeMaxValue()
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_GetHoleSizeMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkFillHolesFilter_GetHoleSizeMinValue_03(HandleRef pThis);

		public virtual double GetHoleSizeMinValue()
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_GetHoleSizeMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFillHolesFilter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFillHolesFilter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFillHolesFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFillHolesFilter NewInstance()
		{
			vtkFillHolesFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFillHolesFilter.vtkFillHolesFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFillHolesFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFillHolesFilter SafeDownCast(vtkObjectBase o)
		{
			vtkFillHolesFilter vtkFillHolesFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFillHolesFilter.vtkFillHolesFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFillHolesFilter = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFillHolesFilter.Register(null);
				}
			}
			return vtkFillHolesFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFillHolesFilter_SetHoleSize_09(HandleRef pThis, double _arg);

		public virtual void SetHoleSize(double _arg)
		{
			vtkFillHolesFilter.vtkFillHolesFilter_SetHoleSize_09(base.GetCppThis(), _arg);
		}
	}
}
