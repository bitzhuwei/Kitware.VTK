using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVoxelContoursToSurfaceFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoxelContoursToSurfaceFilter";

		public new static readonly string MRClassNameKey;

		static vtkVoxelContoursToSurfaceFilter()
		{
			vtkVoxelContoursToSurfaceFilter.MRClassNameKey = "class vtkVoxelContoursToSurfaceFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoxelContoursToSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxelContoursToSurfaceFilter"));
		}

		public vtkVoxelContoursToSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVoxelContoursToSurfaceFilter New()
		{
			vtkVoxelContoursToSurfaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVoxelContoursToSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVoxelContoursToSurfaceFilter_GetMemoryLimitInBytes_01(HandleRef pThis);

		public virtual int GetMemoryLimitInBytes()
		{
			return vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_GetMemoryLimitInBytes_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_GetSpacing_02(HandleRef pThis);

		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_GetSpacing_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVoxelContoursToSurfaceFilter_GetSpacing_03(HandleRef pThis, IntPtr data);

		public virtual void GetSpacing(IntPtr data)
		{
			vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_GetSpacing_03(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVoxelContoursToSurfaceFilter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVoxelContoursToSurfaceFilter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVoxelContoursToSurfaceFilter NewInstance()
		{
			vtkVoxelContoursToSurfaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVoxelContoursToSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVoxelContoursToSurfaceFilter vtkVoxelContoursToSurfaceFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoxelContoursToSurfaceFilter = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoxelContoursToSurfaceFilter.Register(null);
				}
			}
			return vtkVoxelContoursToSurfaceFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVoxelContoursToSurfaceFilter_SetMemoryLimitInBytes_09(HandleRef pThis, int _arg);

		public virtual void SetMemoryLimitInBytes(int _arg)
		{
			vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_SetMemoryLimitInBytes_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVoxelContoursToSurfaceFilter_SetSpacing_10(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_SetSpacing_10(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVoxelContoursToSurfaceFilter_SetSpacing_11(HandleRef pThis, IntPtr _arg);

		public virtual void SetSpacing(IntPtr _arg)
		{
			vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_SetSpacing_11(base.GetCppThis(), _arg);
		}
	}
}
