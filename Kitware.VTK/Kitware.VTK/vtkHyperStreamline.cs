using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperStreamline : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperStreamline";

		public new static readonly string MRClassNameKey;

		static vtkHyperStreamline()
		{
			vtkHyperStreamline.MRClassNameKey = "class vtkHyperStreamline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperStreamline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperStreamline"));
		}

		public vtkHyperStreamline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperStreamline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperStreamline New()
		{
			vtkHyperStreamline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperStreamline.vtkHyperStreamline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperStreamline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperStreamline.vtkHyperStreamline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetIntegrationDirection_01(HandleRef pThis);

		public virtual int GetIntegrationDirection()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationDirection_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetIntegrationDirectionMaxValue_02(HandleRef pThis);

		public virtual int GetIntegrationDirectionMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationDirectionMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetIntegrationDirectionMinValue_03(HandleRef pThis);

		public virtual int GetIntegrationDirectionMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationDirectionMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetIntegrationEigenvector_04(HandleRef pThis);

		public virtual int GetIntegrationEigenvector()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationEigenvector_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetIntegrationEigenvectorMaxValue_05(HandleRef pThis);

		public virtual int GetIntegrationEigenvectorMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationEigenvectorMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetIntegrationEigenvectorMinValue_06(HandleRef pThis);

		public virtual int GetIntegrationEigenvectorMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationEigenvectorMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetIntegrationStepLength_07(HandleRef pThis);

		public virtual double GetIntegrationStepLength()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationStepLength_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetIntegrationStepLengthMaxValue_08(HandleRef pThis);

		public virtual double GetIntegrationStepLengthMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationStepLengthMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetIntegrationStepLengthMinValue_09(HandleRef pThis);

		public virtual double GetIntegrationStepLengthMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationStepLengthMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetLogScaling_10(HandleRef pThis);

		public virtual int GetLogScaling()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetLogScaling_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetMaximumPropagationDistance_11(HandleRef pThis);

		public virtual double GetMaximumPropagationDistance()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetMaximumPropagationDistance_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetMaximumPropagationDistanceMaxValue_12(HandleRef pThis);

		public virtual double GetMaximumPropagationDistanceMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetMaximumPropagationDistanceMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetMaximumPropagationDistanceMinValue_13(HandleRef pThis);

		public virtual double GetMaximumPropagationDistanceMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetMaximumPropagationDistanceMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetNumberOfSides_14(HandleRef pThis);

		public virtual int GetNumberOfSides()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetNumberOfSides_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetNumberOfSidesMaxValue_15(HandleRef pThis);

		public virtual int GetNumberOfSidesMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetNumberOfSidesMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_GetNumberOfSidesMinValue_16(HandleRef pThis);

		public virtual int GetNumberOfSidesMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetNumberOfSidesMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetRadius_17(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetRadius_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetRadiusMaxValue_18(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetRadiusMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetRadiusMinValue_19(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetRadiusMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkHyperStreamline_GetStartLocation_20(HandleRef pThis, ref int subId, IntPtr pcoords);

		public long GetStartLocation(ref int subId, IntPtr pcoords)
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetStartLocation_20(base.GetCppThis(), ref subId, pcoords);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperStreamline_GetStartPosition_21(HandleRef pThis);

		public double[] GetStartPosition()
		{
			IntPtr intPtr = vtkHyperStreamline.vtkHyperStreamline_GetStartPosition_21(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetStepLength_22(HandleRef pThis);

		public virtual double GetStepLength()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetStepLength_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetStepLengthMaxValue_23(HandleRef pThis);

		public virtual double GetStepLengthMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetStepLengthMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetStepLengthMinValue_24(HandleRef pThis);

		public virtual double GetStepLengthMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetStepLengthMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetTerminalEigenvalue_25(HandleRef pThis);

		public virtual double GetTerminalEigenvalue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetTerminalEigenvalue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetTerminalEigenvalueMaxValue_26(HandleRef pThis);

		public virtual double GetTerminalEigenvalueMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetTerminalEigenvalueMaxValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperStreamline_GetTerminalEigenvalueMinValue_27(HandleRef pThis);

		public virtual double GetTerminalEigenvalueMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetTerminalEigenvalueMinValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_IntegrateMajorEigenvector_28(HandleRef pThis);

		public void IntegrateMajorEigenvector()
		{
			vtkHyperStreamline.vtkHyperStreamline_IntegrateMajorEigenvector_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_IntegrateMediumEigenvector_29(HandleRef pThis);

		public void IntegrateMediumEigenvector()
		{
			vtkHyperStreamline.vtkHyperStreamline_IntegrateMediumEigenvector_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_IntegrateMinorEigenvector_30(HandleRef pThis);

		public void IntegrateMinorEigenvector()
		{
			vtkHyperStreamline.vtkHyperStreamline_IntegrateMinorEigenvector_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperStreamline.vtkHyperStreamline_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperStreamline_IsTypeOf_32(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperStreamline.vtkHyperStreamline_IsTypeOf_32(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_LogScalingOff_33(HandleRef pThis);

		public virtual void LogScalingOff()
		{
			vtkHyperStreamline.vtkHyperStreamline_LogScalingOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_LogScalingOn_34(HandleRef pThis);

		public virtual void LogScalingOn()
		{
			vtkHyperStreamline.vtkHyperStreamline_LogScalingOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperStreamline_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperStreamline NewInstance()
		{
			vtkHyperStreamline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperStreamline.vtkHyperStreamline_NewInstance_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperStreamline_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperStreamline SafeDownCast(vtkObjectBase o)
		{
			vtkHyperStreamline vtkHyperStreamline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperStreamline.vtkHyperStreamline_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperStreamline = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperStreamline.Register(null);
				}
			}
			return vtkHyperStreamline;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationDirection_38(HandleRef pThis, int _arg);

		public virtual void SetIntegrationDirection(int _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationDirection_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationDirectionToBackward_39(HandleRef pThis);

		public void SetIntegrationDirectionToBackward()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationDirectionToBackward_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationDirectionToForward_40(HandleRef pThis);

		public void SetIntegrationDirectionToForward()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationDirectionToForward_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationDirectionToIntegrateBothDirections_41(HandleRef pThis);

		public void SetIntegrationDirectionToIntegrateBothDirections()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationDirectionToIntegrateBothDirections_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationEigenvector_42(HandleRef pThis, int _arg);

		public virtual void SetIntegrationEigenvector(int _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationEigenvector_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMajor_43(HandleRef pThis);

		public void SetIntegrationEigenvectorToMajor()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationEigenvectorToMajor_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMedium_44(HandleRef pThis);

		public void SetIntegrationEigenvectorToMedium()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationEigenvectorToMedium_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMinor_45(HandleRef pThis);

		public void SetIntegrationEigenvectorToMinor()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationEigenvectorToMinor_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetIntegrationStepLength_46(HandleRef pThis, double _arg);

		public virtual void SetIntegrationStepLength(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationStepLength_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetLogScaling_47(HandleRef pThis, int _arg);

		public virtual void SetLogScaling(int _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetLogScaling_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetMaximumPropagationDistance_48(HandleRef pThis, double _arg);

		public virtual void SetMaximumPropagationDistance(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetMaximumPropagationDistance_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetNumberOfSides_49(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSides(int _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetNumberOfSides_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetRadius_50(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetRadius_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetStartLocation_51(HandleRef pThis, long cellId, int subId, IntPtr pcoords);

		public void SetStartLocation(long cellId, int subId, IntPtr pcoords)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStartLocation_51(base.GetCppThis(), cellId, subId, pcoords);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetStartLocation_52(HandleRef pThis, long cellId, int subId, double r, double s, double t);

		public void SetStartLocation(long cellId, int subId, double r, double s, double t)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStartLocation_52(base.GetCppThis(), cellId, subId, r, s, t);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetStartPosition_53(HandleRef pThis, IntPtr x);

		public void SetStartPosition(IntPtr x)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStartPosition_53(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetStartPosition_54(HandleRef pThis, double x, double y, double z);

		public void SetStartPosition(double x, double y, double z)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStartPosition_54(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetStepLength_55(HandleRef pThis, double _arg);

		public virtual void SetStepLength(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStepLength_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperStreamline_SetTerminalEigenvalue_56(HandleRef pThis, double _arg);

		public virtual void SetTerminalEigenvalue(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetTerminalEigenvalue_56(base.GetCppThis(), _arg);
		}
	}
}
