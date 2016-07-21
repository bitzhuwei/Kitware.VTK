using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArcSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArcSource";

		public new static readonly string MRClassNameKey;

		static vtkArcSource()
		{
			vtkArcSource.MRClassNameKey = "class vtkArcSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArcSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArcSource"));
		}

		public vtkArcSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArcSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArcSource New()
		{
			vtkArcSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcSource.vtkArcSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArcSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArcSource.vtkArcSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArcSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkArcSource.vtkArcSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_GetCenter_02(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkArcSource.vtkArcSource_GetCenter_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkArcSource_GetNegative_03(HandleRef pThis);

		public virtual bool GetNegative()
		{
			return vtkArcSource.vtkArcSource_GetNegative_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArcSource_GetPoint1_04(HandleRef pThis);

		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkArcSource.vtkArcSource_GetPoint1_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_GetPoint1_05(HandleRef pThis, IntPtr data);

		public virtual void GetPoint1(IntPtr data)
		{
			vtkArcSource.vtkArcSource_GetPoint1_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArcSource_GetPoint2_06(HandleRef pThis);

		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkArcSource.vtkArcSource_GetPoint2_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_GetPoint2_07(HandleRef pThis, IntPtr data);

		public virtual void GetPoint2(IntPtr data)
		{
			vtkArcSource.vtkArcSource_GetPoint2_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArcSource_GetResolution_08(HandleRef pThis);

		public virtual int GetResolution()
		{
			return vtkArcSource.vtkArcSource_GetResolution_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArcSource_GetResolutionMaxValue_09(HandleRef pThis);

		public virtual int GetResolutionMaxValue()
		{
			return vtkArcSource.vtkArcSource_GetResolutionMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArcSource_GetResolutionMinValue_10(HandleRef pThis);

		public virtual int GetResolutionMinValue()
		{
			return vtkArcSource.vtkArcSource_GetResolutionMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArcSource_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArcSource.vtkArcSource_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArcSource_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArcSource.vtkArcSource_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_NegativeOff_13(HandleRef pThis);

		public virtual void NegativeOff()
		{
			vtkArcSource.vtkArcSource_NegativeOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_NegativeOn_14(HandleRef pThis);

		public virtual void NegativeOn()
		{
			vtkArcSource.vtkArcSource_NegativeOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArcSource_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArcSource NewInstance()
		{
			vtkArcSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcSource.vtkArcSource_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArcSource_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArcSource SafeDownCast(vtkObjectBase o)
		{
			vtkArcSource vtkArcSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcSource.vtkArcSource_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArcSource = (vtkArcSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArcSource.Register(null);
				}
			}
			return vtkArcSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_SetCenter_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkArcSource.vtkArcSource_SetCenter_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_SetCenter_19(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkArcSource.vtkArcSource_SetCenter_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_SetNegative_20(HandleRef pThis, byte _arg);

		public virtual void SetNegative(bool _arg)
		{
			vtkArcSource.vtkArcSource_SetNegative_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_SetPoint1_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
		{
			vtkArcSource.vtkArcSource_SetPoint1_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_SetPoint1_22(HandleRef pThis, IntPtr _arg);

		public virtual void SetPoint1(IntPtr _arg)
		{
			vtkArcSource.vtkArcSource_SetPoint1_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_SetPoint2_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
		{
			vtkArcSource.vtkArcSource_SetPoint2_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_SetPoint2_24(HandleRef pThis, IntPtr _arg);

		public virtual void SetPoint2(IntPtr _arg)
		{
			vtkArcSource.vtkArcSource_SetPoint2_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArcSource_SetResolution_25(HandleRef pThis, int _arg);

		public virtual void SetResolution(int _arg)
		{
			vtkArcSource.vtkArcSource_SetResolution_25(base.GetCppThis(), _arg);
		}
	}
}
