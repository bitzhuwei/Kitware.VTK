using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSimpleElevationFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleElevationFilter";

		public new static readonly string MRClassNameKey;

		static vtkSimpleElevationFilter()
		{
			vtkSimpleElevationFilter.MRClassNameKey = "class vtkSimpleElevationFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleElevationFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleElevationFilter"));
		}

		public vtkSimpleElevationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleElevationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleElevationFilter New()
		{
			vtkSimpleElevationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleElevationFilter.vtkSimpleElevationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleElevationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSimpleElevationFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSimpleElevationFilter.vtkSimpleElevationFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleElevationFilter_GetVector_01(HandleRef pThis);

		public virtual double[] GetVector()
		{
			IntPtr intPtr = vtkSimpleElevationFilter.vtkSimpleElevationFilter_GetVector_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSimpleElevationFilter_GetVector_02(HandleRef pThis, IntPtr data);

		public virtual void GetVector(IntPtr data)
		{
			vtkSimpleElevationFilter.vtkSimpleElevationFilter_GetVector_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSimpleElevationFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSimpleElevationFilter.vtkSimpleElevationFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSimpleElevationFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSimpleElevationFilter.vtkSimpleElevationFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleElevationFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSimpleElevationFilter NewInstance()
		{
			vtkSimpleElevationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleElevationFilter.vtkSimpleElevationFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleElevationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleElevationFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleElevationFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleElevationFilter vtkSimpleElevationFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleElevationFilter.vtkSimpleElevationFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleElevationFilter = (vtkSimpleElevationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleElevationFilter.Register(null);
				}
			}
			return vtkSimpleElevationFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSimpleElevationFilter_SetVector_08(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetVector(double _arg1, double _arg2, double _arg3)
		{
			vtkSimpleElevationFilter.vtkSimpleElevationFilter_SetVector_08(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSimpleElevationFilter_SetVector_09(HandleRef pThis, IntPtr _arg);

		public virtual void SetVector(IntPtr _arg)
		{
			vtkSimpleElevationFilter.vtkSimpleElevationFilter_SetVector_09(base.GetCppThis(), _arg);
		}
	}
}
