using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSource";

		public new static readonly string MRClassNameKey;

		static vtkPointSource()
		{
			vtkPointSource.MRClassNameKey = "class vtkPointSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSource"));
		}

		public vtkPointSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointSource New()
		{
			vtkPointSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointSource.vtkPointSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointSource.vtkPointSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkPointSource.vtkPointSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointSource_GetCenter_02(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkPointSource.vtkPointSource_GetCenter_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPointSource_GetDistribution_03(HandleRef pThis);

		public virtual int GetDistribution()
		{
			return vtkPointSource.vtkPointSource_GetDistribution_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkPointSource_GetNumberOfPoints_04(HandleRef pThis);

		public virtual long GetNumberOfPoints()
		{
			return vtkPointSource.vtkPointSource_GetNumberOfPoints_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkPointSource_GetNumberOfPointsMaxValue_05(HandleRef pThis);

		public virtual long GetNumberOfPointsMaxValue()
		{
			return vtkPointSource.vtkPointSource_GetNumberOfPointsMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkPointSource_GetNumberOfPointsMinValue_06(HandleRef pThis);

		public virtual long GetNumberOfPointsMinValue()
		{
			return vtkPointSource.vtkPointSource_GetNumberOfPointsMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPointSource_GetRadius_07(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkPointSource.vtkPointSource_GetRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPointSource_GetRadiusMaxValue_08(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkPointSource.vtkPointSource_GetRadiusMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPointSource_GetRadiusMinValue_09(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkPointSource.vtkPointSource_GetRadiusMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPointSource_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointSource.vtkPointSource_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPointSource_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointSource.vtkPointSource_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointSource NewInstance()
		{
			vtkPointSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointSource.vtkPointSource_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointSource SafeDownCast(vtkObjectBase o)
		{
			vtkPointSource vtkPointSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointSource.vtkPointSource_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSource = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSource.Register(null);
				}
			}
			return vtkPointSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointSource_SetCenter_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkPointSource.vtkPointSource_SetCenter_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointSource_SetCenter_16(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkPointSource.vtkPointSource_SetCenter_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointSource_SetDistribution_17(HandleRef pThis, int _arg);

		public virtual void SetDistribution(int _arg)
		{
			vtkPointSource.vtkPointSource_SetDistribution_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointSource_SetDistributionToShell_18(HandleRef pThis);

		public void SetDistributionToShell()
		{
			vtkPointSource.vtkPointSource_SetDistributionToShell_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointSource_SetDistributionToUniform_19(HandleRef pThis);

		public void SetDistributionToUniform()
		{
			vtkPointSource.vtkPointSource_SetDistributionToUniform_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointSource_SetNumberOfPoints_20(HandleRef pThis, long _arg);

		public virtual void SetNumberOfPoints(long _arg)
		{
			vtkPointSource.vtkPointSource_SetNumberOfPoints_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointSource_SetRadius_21(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkPointSource.vtkPointSource_SetRadius_21(base.GetCppThis(), _arg);
		}
	}
}
