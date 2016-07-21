using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeFractalSource : vtkHyperOctreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeFractalSource";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeFractalSource()
		{
			vtkHyperOctreeFractalSource.MRClassNameKey = "class vtkHyperOctreeFractalSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeFractalSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeFractalSource"));
		}

		public vtkHyperOctreeFractalSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeFractalSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeFractalSource New()
		{
			vtkHyperOctreeFractalSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeFractalSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeFractalSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeFractalSource_GetDimension_01(HandleRef pThis);

		public virtual int GetDimension()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetDimension_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeFractalSource_GetDimensionMaxValue_02(HandleRef pThis);

		public virtual int GetDimensionMaxValue()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetDimensionMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeFractalSource_GetDimensionMinValue_03(HandleRef pThis);

		public virtual int GetDimensionMinValue()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetDimensionMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeFractalSource_GetMaximumLevel_04(HandleRef pThis);

		public int GetMaximumLevel()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetMaximumLevel_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkHyperOctreeFractalSource_GetMaximumNumberOfIterations_05(HandleRef pThis);

		public virtual byte GetMaximumNumberOfIterations()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetMaximumNumberOfIterations_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern ushort vtkHyperOctreeFractalSource_GetMaximumNumberOfIterationsMaxValue_06(HandleRef pThis);

		public virtual ushort GetMaximumNumberOfIterationsMaxValue()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetMaximumNumberOfIterationsMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern ushort vtkHyperOctreeFractalSource_GetMaximumNumberOfIterationsMinValue_07(HandleRef pThis);

		public virtual ushort GetMaximumNumberOfIterationsMinValue()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetMaximumNumberOfIterationsMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeFractalSource_GetMinimumLevel_08(HandleRef pThis);

		public int GetMinimumLevel()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetMinimumLevel_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeFractalSource_GetOriginCX_09(HandleRef pThis);

		public virtual double[] GetOriginCX()
		{
			IntPtr intPtr = vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetOriginCX_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_GetOriginCX_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetOriginCX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetOriginCX_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_GetOriginCX_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetOriginCX(IntPtr _arg)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetOriginCX_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeFractalSource_GetProjectionAxes_12(HandleRef pThis);

		public virtual int[] GetProjectionAxes()
		{
			IntPtr intPtr = vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetProjectionAxes_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_GetProjectionAxes_13(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetProjectionAxes(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetProjectionAxes_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_GetProjectionAxes_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetProjectionAxes(IntPtr _arg)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetProjectionAxes_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeFractalSource_GetSizeCX_15(HandleRef pThis);

		public virtual double[] GetSizeCX()
		{
			IntPtr intPtr = vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetSizeCX_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_GetSizeCX_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetSizeCX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetSizeCX_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_GetSizeCX_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetSizeCX(IntPtr _arg)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetSizeCX_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperOctreeFractalSource_GetSpanThreshold_18(HandleRef pThis);

		public virtual double GetSpanThreshold()
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_GetSpanThreshold_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeFractalSource_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeFractalSource_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeFractalSource_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeFractalSource NewInstance()
		{
			vtkHyperOctreeFractalSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeFractalSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeFractalSource_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeFractalSource SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeFractalSource vtkHyperOctreeFractalSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeFractalSource = (vtkHyperOctreeFractalSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeFractalSource.Register(null);
				}
			}
			return vtkHyperOctreeFractalSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetDimension_24(HandleRef pThis, int _arg);

		public virtual void SetDimension(int _arg)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetDimension_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetMaximumLevel_25(HandleRef pThis, int levels);

		public void SetMaximumLevel(int levels)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetMaximumLevel_25(base.GetCppThis(), levels);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetMaximumNumberOfIterations_26(HandleRef pThis, ushort _arg);

		public virtual void SetMaximumNumberOfIterations(ushort _arg)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetMaximumNumberOfIterations_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetMinimumLevel_27(HandleRef pThis, int level);

		public void SetMinimumLevel(int level)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetMinimumLevel_27(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetOriginCX_28(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetOriginCX(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetOriginCX_28(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetOriginCX_29(HandleRef pThis, IntPtr _arg);

		public virtual void SetOriginCX(IntPtr _arg)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetOriginCX_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetProjectionAxes_30(HandleRef pThis, int x, int y, int z);

		public void SetProjectionAxes(int x, int y, int z)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetProjectionAxes_30(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetProjectionAxes_31(HandleRef pThis, IntPtr a);

		public void SetProjectionAxes(IntPtr a)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetProjectionAxes_31(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetSizeCX_32(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetSizeCX(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetSizeCX_32(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetSizeCX_33(HandleRef pThis, IntPtr _arg);

		public virtual void SetSizeCX(IntPtr _arg)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetSizeCX_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeFractalSource_SetSpanThreshold_34(HandleRef pThis, double _arg);

		public virtual void SetSpanThreshold(double _arg)
		{
			vtkHyperOctreeFractalSource.vtkHyperOctreeFractalSource_SetSpanThreshold_34(base.GetCppThis(), _arg);
		}
	}
}
