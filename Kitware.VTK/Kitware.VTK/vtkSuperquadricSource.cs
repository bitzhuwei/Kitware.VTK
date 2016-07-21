using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSuperquadricSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSuperquadricSource";

		public new static readonly string MRClassNameKey;

		static vtkSuperquadricSource()
		{
			vtkSuperquadricSource.MRClassNameKey = "class vtkSuperquadricSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSuperquadricSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSuperquadricSource"));
		}

		public vtkSuperquadricSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadricSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSuperquadricSource New()
		{
			vtkSuperquadricSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSuperquadricSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSuperquadricSource.vtkSuperquadricSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadricSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_GetCenter_02(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_GetCenter_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSuperquadricSource_GetPhiResolution_03(HandleRef pThis);

		public virtual int GetPhiResolution()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetPhiResolution_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSuperquadricSource_GetPhiRoundness_04(HandleRef pThis);

		public virtual double GetPhiRoundness()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetPhiRoundness_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadricSource_GetScale_05(HandleRef pThis);

		public virtual double[] GetScale()
		{
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_GetScale_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_GetScale_06(HandleRef pThis, IntPtr data);

		public virtual void GetScale(IntPtr data)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_GetScale_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSuperquadricSource_GetSize_07(HandleRef pThis);

		public virtual double GetSize()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSuperquadricSource_GetThetaResolution_08(HandleRef pThis);

		public virtual int GetThetaResolution()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThetaResolution_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSuperquadricSource_GetThetaRoundness_09(HandleRef pThis);

		public virtual double GetThetaRoundness()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThetaRoundness_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSuperquadricSource_GetThickness_10(HandleRef pThis);

		public virtual double GetThickness()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThickness_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSuperquadricSource_GetThicknessMaxValue_11(HandleRef pThis);

		public virtual double GetThicknessMaxValue()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThicknessMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSuperquadricSource_GetThicknessMinValue_12(HandleRef pThis);

		public virtual double GetThicknessMinValue()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetThicknessMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSuperquadricSource_GetToroidal_13(HandleRef pThis);

		public virtual int GetToroidal()
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_GetToroidal_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSuperquadricSource_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSuperquadricSource_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSuperquadricSource.vtkSuperquadricSource_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadricSource_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSuperquadricSource NewInstance()
		{
			vtkSuperquadricSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadricSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSuperquadricSource SafeDownCast(vtkObjectBase o)
		{
			vtkSuperquadricSource vtkSuperquadricSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSuperquadricSource.vtkSuperquadricSource_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSuperquadricSource = (vtkSuperquadricSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSuperquadricSource.Register(null);
				}
			}
			return vtkSuperquadricSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetCenter_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetCenter_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetCenter_20(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetCenter_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetPhiResolution_21(HandleRef pThis, int i);

		public void SetPhiResolution(int i)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetPhiResolution_21(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetPhiRoundness_22(HandleRef pThis, double e);

		public void SetPhiRoundness(double e)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetPhiRoundness_22(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetScale_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetScale(double _arg1, double _arg2, double _arg3)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetScale_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetScale_24(HandleRef pThis, IntPtr _arg);

		public virtual void SetScale(IntPtr _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetScale_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetSize_25(HandleRef pThis, double _arg);

		public virtual void SetSize(double _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetSize_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetThetaResolution_26(HandleRef pThis, int i);

		public void SetThetaResolution(int i)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetThetaResolution_26(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetThetaRoundness_27(HandleRef pThis, double e);

		public void SetThetaRoundness(double e)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetThetaRoundness_27(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetThickness_28(HandleRef pThis, double _arg);

		public virtual void SetThickness(double _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetThickness_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_SetToroidal_29(HandleRef pThis, int _arg);

		public virtual void SetToroidal(int _arg)
		{
			vtkSuperquadricSource.vtkSuperquadricSource_SetToroidal_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_ToroidalOff_30(HandleRef pThis);

		public virtual void ToroidalOff()
		{
			vtkSuperquadricSource.vtkSuperquadricSource_ToroidalOff_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSuperquadricSource_ToroidalOn_31(HandleRef pThis);

		public virtual void ToroidalOn()
		{
			vtkSuperquadricSource.vtkSuperquadricSource_ToroidalOn_31(base.GetCppThis());
		}
	}
}
