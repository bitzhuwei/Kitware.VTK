using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadricClustering : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricClustering";

		public new static readonly string MRClassNameKey;

		static vtkQuadricClustering()
		{
			vtkQuadricClustering.MRClassNameKey = "class vtkQuadricClustering";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadricClustering.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricClustering"));
		}

		public vtkQuadricClustering(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricClustering_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadricClustering New()
		{
			vtkQuadricClustering result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadricClustering() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadricClustering.vtkQuadricClustering_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_Append_01(HandleRef pThis, HandleRef piece);

		public void Append(vtkPolyData piece)
		{
			vtkQuadricClustering.vtkQuadricClustering_Append_01(base.GetCppThis(), (piece == null) ? default(HandleRef) : piece.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_AutoAdjustNumberOfDivisionsOff_02(HandleRef pThis);

		public virtual void AutoAdjustNumberOfDivisionsOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_AutoAdjustNumberOfDivisionsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_AutoAdjustNumberOfDivisionsOn_03(HandleRef pThis);

		public virtual void AutoAdjustNumberOfDivisionsOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_AutoAdjustNumberOfDivisionsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_CopyCellDataOff_04(HandleRef pThis);

		public virtual void CopyCellDataOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_CopyCellDataOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_CopyCellDataOn_05(HandleRef pThis);

		public virtual void CopyCellDataOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_CopyCellDataOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_EndAppend_06(HandleRef pThis);

		public void EndAppend()
		{
			vtkQuadricClustering.vtkQuadricClustering_EndAppend_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetAutoAdjustNumberOfDivisions_07(HandleRef pThis);

		public virtual int GetAutoAdjustNumberOfDivisions()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetAutoAdjustNumberOfDivisions_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetCopyCellData_08(HandleRef pThis);

		public virtual int GetCopyCellData()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetCopyCellData_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricClustering_GetDivisionOrigin_09(HandleRef pThis);

		public virtual double[] GetDivisionOrigin()
		{
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_GetDivisionOrigin_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_GetDivisionOrigin_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDivisionOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetDivisionOrigin_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_GetDivisionOrigin_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetDivisionOrigin(IntPtr _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetDivisionOrigin_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricClustering_GetDivisionSpacing_12(HandleRef pThis);

		public virtual double[] GetDivisionSpacing()
		{
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_GetDivisionSpacing_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_GetDivisionSpacing_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDivisionSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetDivisionSpacing_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_GetDivisionSpacing_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetDivisionSpacing(IntPtr _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetDivisionSpacing_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricClustering_GetFeatureEdges_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkFeatureEdges GetFeatureEdges()
		{
			vtkFeatureEdges vtkFeatureEdges = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_GetFeatureEdges_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFeatureEdges = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFeatureEdges.Register(null);
				}
			}
			return vtkFeatureEdges;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricClustering_GetFeaturePointsAngle_16(HandleRef pThis);

		public virtual double GetFeaturePointsAngle()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetFeaturePointsAngle_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricClustering_GetFeaturePointsAngleMaxValue_17(HandleRef pThis);

		public virtual double GetFeaturePointsAngleMaxValue()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetFeaturePointsAngleMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricClustering_GetFeaturePointsAngleMinValue_18(HandleRef pThis);

		public virtual double GetFeaturePointsAngleMinValue()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetFeaturePointsAngleMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricClustering_GetNumberOfDivisions_19(HandleRef pThis);

		public int[] GetNumberOfDivisions()
		{
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_GetNumberOfDivisions_19(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_GetNumberOfDivisions_20(HandleRef pThis, IntPtr div);

		public void GetNumberOfDivisions(IntPtr div)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetNumberOfDivisions_20(base.GetCppThis(), div);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetNumberOfXDivisions_21(HandleRef pThis);

		public virtual int GetNumberOfXDivisions()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetNumberOfXDivisions_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetNumberOfYDivisions_22(HandleRef pThis);

		public virtual int GetNumberOfYDivisions()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetNumberOfYDivisions_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetNumberOfZDivisions_23(HandleRef pThis);

		public virtual int GetNumberOfZDivisions()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetNumberOfZDivisions_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetPreventDuplicateCells_24(HandleRef pThis);

		public virtual int GetPreventDuplicateCells()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetPreventDuplicateCells_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetUseFeatureEdges_25(HandleRef pThis);

		public virtual int GetUseFeatureEdges()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetUseFeatureEdges_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetUseFeaturePoints_26(HandleRef pThis);

		public virtual int GetUseFeaturePoints()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetUseFeaturePoints_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetUseInputPoints_27(HandleRef pThis);

		public virtual int GetUseInputPoints()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetUseInputPoints_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_GetUseInternalTriangles_28(HandleRef pThis);

		public virtual int GetUseInternalTriangles()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetUseInternalTriangles_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_IsA_29(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadricClustering.vtkQuadricClustering_IsA_29(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricClustering_IsTypeOf_30(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadricClustering.vtkQuadricClustering_IsTypeOf_30(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricClustering_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadricClustering NewInstance()
		{
			vtkQuadricClustering result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_PreventDuplicateCellsOff_33(HandleRef pThis);

		public virtual void PreventDuplicateCellsOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_PreventDuplicateCellsOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_PreventDuplicateCellsOn_34(HandleRef pThis);

		public virtual void PreventDuplicateCellsOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_PreventDuplicateCellsOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricClustering_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadricClustering SafeDownCast(vtkObjectBase o)
		{
			vtkQuadricClustering vtkQuadricClustering = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadricClustering = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadricClustering.Register(null);
				}
			}
			return vtkQuadricClustering;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetAutoAdjustNumberOfDivisions_36(HandleRef pThis, int _arg);

		public virtual void SetAutoAdjustNumberOfDivisions(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetAutoAdjustNumberOfDivisions_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetCopyCellData_37(HandleRef pThis, int _arg);

		public virtual void SetCopyCellData(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetCopyCellData_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetDivisionOrigin_38(HandleRef pThis, double x, double y, double z);

		public void SetDivisionOrigin(double x, double y, double z)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetDivisionOrigin_38(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetDivisionOrigin_39(HandleRef pThis, IntPtr o);

		public void SetDivisionOrigin(IntPtr o)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetDivisionOrigin_39(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetDivisionSpacing_40(HandleRef pThis, double x, double y, double z);

		public void SetDivisionSpacing(double x, double y, double z)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetDivisionSpacing_40(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetDivisionSpacing_41(HandleRef pThis, IntPtr s);

		public void SetDivisionSpacing(IntPtr s)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetDivisionSpacing_41(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetFeaturePointsAngle_42(HandleRef pThis, double _arg);

		public virtual void SetFeaturePointsAngle(double _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetFeaturePointsAngle_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetNumberOfDivisions_43(HandleRef pThis, IntPtr div);

		public void SetNumberOfDivisions(IntPtr div)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfDivisions_43(base.GetCppThis(), div);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetNumberOfDivisions_44(HandleRef pThis, int div0, int div1, int div2);

		public void SetNumberOfDivisions(int div0, int div1, int div2)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfDivisions_44(base.GetCppThis(), div0, div1, div2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetNumberOfXDivisions_45(HandleRef pThis, int num);

		public void SetNumberOfXDivisions(int num)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfXDivisions_45(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetNumberOfYDivisions_46(HandleRef pThis, int num);

		public void SetNumberOfYDivisions(int num)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfYDivisions_46(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetNumberOfZDivisions_47(HandleRef pThis, int num);

		public void SetNumberOfZDivisions(int num)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfZDivisions_47(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetPreventDuplicateCells_48(HandleRef pThis, int _arg);

		public virtual void SetPreventDuplicateCells(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetPreventDuplicateCells_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetUseFeatureEdges_49(HandleRef pThis, int _arg);

		public virtual void SetUseFeatureEdges(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetUseFeatureEdges_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetUseFeaturePoints_50(HandleRef pThis, int _arg);

		public virtual void SetUseFeaturePoints(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetUseFeaturePoints_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetUseInputPoints_51(HandleRef pThis, int _arg);

		public virtual void SetUseInputPoints(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetUseInputPoints_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_SetUseInternalTriangles_52(HandleRef pThis, int _arg);

		public virtual void SetUseInternalTriangles(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetUseInternalTriangles_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_StartAppend_53(HandleRef pThis, IntPtr bounds);

		public void StartAppend(IntPtr bounds)
		{
			vtkQuadricClustering.vtkQuadricClustering_StartAppend_53(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_StartAppend_54(HandleRef pThis, double x0, double x1, double y0, double y1, double z0, double z1);

		public void StartAppend(double x0, double x1, double y0, double y1, double z0, double z1)
		{
			vtkQuadricClustering.vtkQuadricClustering_StartAppend_54(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_UseFeatureEdgesOff_55(HandleRef pThis);

		public virtual void UseFeatureEdgesOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseFeatureEdgesOff_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_UseFeatureEdgesOn_56(HandleRef pThis);

		public virtual void UseFeatureEdgesOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseFeatureEdgesOn_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_UseFeaturePointsOff_57(HandleRef pThis);

		public virtual void UseFeaturePointsOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseFeaturePointsOff_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_UseFeaturePointsOn_58(HandleRef pThis);

		public virtual void UseFeaturePointsOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseFeaturePointsOn_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_UseInputPointsOff_59(HandleRef pThis);

		public virtual void UseInputPointsOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseInputPointsOff_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_UseInputPointsOn_60(HandleRef pThis);

		public virtual void UseInputPointsOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseInputPointsOn_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_UseInternalTrianglesOff_61(HandleRef pThis);

		public virtual void UseInternalTrianglesOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseInternalTrianglesOff_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricClustering_UseInternalTrianglesOn_62(HandleRef pThis);

		public virtual void UseInternalTrianglesOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseInternalTrianglesOn_62(base.GetCppThis());
		}
	}
}
