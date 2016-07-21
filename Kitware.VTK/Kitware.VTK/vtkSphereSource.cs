using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSphereSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereSource";

		public new static readonly string MRClassNameKey;

		static vtkSphereSource()
		{
			vtkSphereSource.MRClassNameKey = "class vtkSphereSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereSource"));
		}

		public vtkSphereSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereSource New()
		{
			vtkSphereSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereSource.vtkSphereSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSphereSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSphereSource.vtkSphereSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkSphereSource.vtkSphereSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_GetCenter_02(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkSphereSource.vtkSphereSource_GetCenter_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetEndPhi_03(HandleRef pThis);

		public virtual double GetEndPhi()
		{
			return vtkSphereSource.vtkSphereSource_GetEndPhi_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetEndPhiMaxValue_04(HandleRef pThis);

		public virtual double GetEndPhiMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetEndPhiMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetEndPhiMinValue_05(HandleRef pThis);

		public virtual double GetEndPhiMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetEndPhiMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetEndTheta_06(HandleRef pThis);

		public virtual double GetEndTheta()
		{
			return vtkSphereSource.vtkSphereSource_GetEndTheta_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetEndThetaMaxValue_07(HandleRef pThis);

		public virtual double GetEndThetaMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetEndThetaMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetEndThetaMinValue_08(HandleRef pThis);

		public virtual double GetEndThetaMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetEndThetaMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_GetLatLongTessellation_09(HandleRef pThis);

		public virtual int GetLatLongTessellation()
		{
			return vtkSphereSource.vtkSphereSource_GetLatLongTessellation_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_GetPhiResolution_10(HandleRef pThis);

		public virtual int GetPhiResolution()
		{
			return vtkSphereSource.vtkSphereSource_GetPhiResolution_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_GetPhiResolutionMaxValue_11(HandleRef pThis);

		public virtual int GetPhiResolutionMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetPhiResolutionMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_GetPhiResolutionMinValue_12(HandleRef pThis);

		public virtual int GetPhiResolutionMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetPhiResolutionMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetRadius_13(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkSphereSource.vtkSphereSource_GetRadius_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetRadiusMaxValue_14(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetRadiusMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetRadiusMinValue_15(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetRadiusMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetStartPhi_16(HandleRef pThis);

		public virtual double GetStartPhi()
		{
			return vtkSphereSource.vtkSphereSource_GetStartPhi_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetStartPhiMaxValue_17(HandleRef pThis);

		public virtual double GetStartPhiMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetStartPhiMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetStartPhiMinValue_18(HandleRef pThis);

		public virtual double GetStartPhiMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetStartPhiMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetStartTheta_19(HandleRef pThis);

		public virtual double GetStartTheta()
		{
			return vtkSphereSource.vtkSphereSource_GetStartTheta_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetStartThetaMaxValue_20(HandleRef pThis);

		public virtual double GetStartThetaMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetStartThetaMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSphereSource_GetStartThetaMinValue_21(HandleRef pThis);

		public virtual double GetStartThetaMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetStartThetaMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_GetThetaResolution_22(HandleRef pThis);

		public virtual int GetThetaResolution()
		{
			return vtkSphereSource.vtkSphereSource_GetThetaResolution_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_GetThetaResolutionMaxValue_23(HandleRef pThis);

		public virtual int GetThetaResolutionMaxValue()
		{
			return vtkSphereSource.vtkSphereSource_GetThetaResolutionMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_GetThetaResolutionMinValue_24(HandleRef pThis);

		public virtual int GetThetaResolutionMinValue()
		{
			return vtkSphereSource.vtkSphereSource_GetThetaResolutionMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSphereSource.vtkSphereSource_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSphereSource_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSphereSource.vtkSphereSource_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_LatLongTessellationOff_27(HandleRef pThis);

		public virtual void LatLongTessellationOff()
		{
			vtkSphereSource.vtkSphereSource_LatLongTessellationOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_LatLongTessellationOn_28(HandleRef pThis);

		public virtual void LatLongTessellationOn()
		{
			vtkSphereSource.vtkSphereSource_LatLongTessellationOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereSource_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSphereSource NewInstance()
		{
			vtkSphereSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereSource.vtkSphereSource_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereSource_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereSource SafeDownCast(vtkObjectBase o)
		{
			vtkSphereSource vtkSphereSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereSource.vtkSphereSource_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereSource = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereSource.Register(null);
				}
			}
			return vtkSphereSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetCenter_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkSphereSource.vtkSphereSource_SetCenter_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetCenter_33(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkSphereSource.vtkSphereSource_SetCenter_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetEndPhi_34(HandleRef pThis, double _arg);

		public virtual void SetEndPhi(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetEndPhi_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetEndTheta_35(HandleRef pThis, double _arg);

		public virtual void SetEndTheta(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetEndTheta_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetLatLongTessellation_36(HandleRef pThis, int _arg);

		public virtual void SetLatLongTessellation(int _arg)
		{
			vtkSphereSource.vtkSphereSource_SetLatLongTessellation_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetPhiResolution_37(HandleRef pThis, int _arg);

		public virtual void SetPhiResolution(int _arg)
		{
			vtkSphereSource.vtkSphereSource_SetPhiResolution_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetRadius_38(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetRadius_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetStartPhi_39(HandleRef pThis, double _arg);

		public virtual void SetStartPhi(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetStartPhi_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetStartTheta_40(HandleRef pThis, double _arg);

		public virtual void SetStartTheta(double _arg)
		{
			vtkSphereSource.vtkSphereSource_SetStartTheta_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSphereSource_SetThetaResolution_41(HandleRef pThis, int _arg);

		public virtual void SetThetaResolution(int _arg)
		{
			vtkSphereSource.vtkSphereSource_SetThetaResolution_41(base.GetCppThis(), _arg);
		}
	}
}
