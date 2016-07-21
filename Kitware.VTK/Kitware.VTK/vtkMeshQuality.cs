using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMeshQuality : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMeshQuality";

		public new static readonly string MRClassNameKey;

		static vtkMeshQuality()
		{
			vtkMeshQuality.MRClassNameKey = "class vtkMeshQuality";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMeshQuality.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMeshQuality"));
		}

		public vtkMeshQuality(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMeshQuality_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMeshQuality New()
		{
			vtkMeshQuality result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMeshQuality.vtkMeshQuality_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMeshQuality() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMeshQuality.vtkMeshQuality_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_CompatibilityModeOff_01(HandleRef pThis);

		public virtual void CompatibilityModeOff()
		{
			vtkMeshQuality.vtkMeshQuality_CompatibilityModeOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_CompatibilityModeOn_02(HandleRef pThis);

		public virtual void CompatibilityModeOn()
		{
			vtkMeshQuality.vtkMeshQuality_CompatibilityModeOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_GetCompatibilityMode_03(HandleRef pThis);

		public virtual int GetCompatibilityMode()
		{
			return vtkMeshQuality.vtkMeshQuality_GetCompatibilityMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_GetHexQualityMeasure_04(HandleRef pThis);

		public virtual int GetHexQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetHexQualityMeasure_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_GetQuadQualityMeasure_05(HandleRef pThis);

		public virtual int GetQuadQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetQuadQualityMeasure_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_GetRatio_06(HandleRef pThis);

		public int GetRatio()
		{
			return vtkMeshQuality.vtkMeshQuality_GetRatio_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_GetSaveCellQuality_07(HandleRef pThis);

		public virtual int GetSaveCellQuality()
		{
			return vtkMeshQuality.vtkMeshQuality_GetSaveCellQuality_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_GetTetQualityMeasure_08(HandleRef pThis);

		public virtual int GetTetQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetTetQualityMeasure_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_GetTriangleQualityMeasure_09(HandleRef pThis);

		public virtual int GetTriangleQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetTriangleQualityMeasure_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_GetVolume_10(HandleRef pThis);

		public int GetVolume()
		{
			return vtkMeshQuality.vtkMeshQuality_GetVolume_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexCondition_11(HandleRef cell);

		public static double HexCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexCondition_11((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexDiagonal_12(HandleRef cell);

		public static double HexDiagonal(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexDiagonal_12((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexDimension_13(HandleRef cell);

		public static double HexDimension(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexDimension_13((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexDistortion_14(HandleRef cell);

		public static double HexDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexDistortion_14((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexEdgeRatio_15(HandleRef cell);

		public static double HexEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexEdgeRatio_15((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexJacobian_16(HandleRef cell);

		public static double HexJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexJacobian_16((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexMaxAspectFrobenius_17(HandleRef cell);

		public static double HexMaxAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexMaxAspectFrobenius_17((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexMaxEdgeRatio_18(HandleRef cell);

		public static double HexMaxEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexMaxEdgeRatio_18((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexMedAspectFrobenius_19(HandleRef cell);

		public static double HexMedAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexMedAspectFrobenius_19((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexOddy_20(HandleRef cell);

		public static double HexOddy(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexOddy_20((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexRelativeSizeSquared_21(HandleRef cell);

		public static double HexRelativeSizeSquared(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexRelativeSizeSquared_21((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexScaledJacobian_22(HandleRef cell);

		public static double HexScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexScaledJacobian_22((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexShape_23(HandleRef cell);

		public static double HexShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexShape_23((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexShapeAndSize_24(HandleRef cell);

		public static double HexShapeAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexShapeAndSize_24((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexShear_25(HandleRef cell);

		public static double HexShear(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexShear_25((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexShearAndSize_26(HandleRef cell);

		public static double HexShearAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexShearAndSize_26((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexSkew_27(HandleRef cell);

		public static double HexSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexSkew_27((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexStretch_28(HandleRef cell);

		public static double HexStretch(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexStretch_28((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexTaper_29(HandleRef cell);

		public static double HexTaper(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexTaper_29((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_HexVolume_30(HandleRef cell);

		public static double HexVolume(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexVolume_30((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMeshQuality.vtkMeshQuality_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMeshQuality_IsTypeOf_32(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMeshQuality.vtkMeshQuality_IsTypeOf_32(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMeshQuality_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMeshQuality NewInstance()
		{
			vtkMeshQuality result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMeshQuality.vtkMeshQuality_NewInstance_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadArea_35(HandleRef cell);

		public static double QuadArea(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadArea_35((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadAspectRatio_36(HandleRef cell);

		public static double QuadAspectRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadAspectRatio_36((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadCondition_37(HandleRef cell);

		public static double QuadCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadCondition_37((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadDistortion_38(HandleRef cell);

		public static double QuadDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadDistortion_38((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadEdgeRatio_39(HandleRef cell);

		public static double QuadEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadEdgeRatio_39((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadJacobian_40(HandleRef cell);

		public static double QuadJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadJacobian_40((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadMaxAngle_41(HandleRef cell);

		public static double QuadMaxAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMaxAngle_41((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadMaxAspectFrobenius_42(HandleRef cell);

		public static double QuadMaxAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMaxAspectFrobenius_42((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadMaxEdgeRatios_43(HandleRef cell);

		public static double QuadMaxEdgeRatios(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMaxEdgeRatios_43((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadMedAspectFrobenius_44(HandleRef cell);

		public static double QuadMedAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMedAspectFrobenius_44((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadMinAngle_45(HandleRef cell);

		public static double QuadMinAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMinAngle_45((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadOddy_46(HandleRef cell);

		public static double QuadOddy(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadOddy_46((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadRadiusRatio_47(HandleRef cell);

		public static double QuadRadiusRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadRadiusRatio_47((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadRelativeSizeSquared_48(HandleRef cell);

		public static double QuadRelativeSizeSquared(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadRelativeSizeSquared_48((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadScaledJacobian_49(HandleRef cell);

		public static double QuadScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadScaledJacobian_49((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadShape_50(HandleRef cell);

		public static double QuadShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadShape_50((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadShapeAndSize_51(HandleRef cell);

		public static double QuadShapeAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadShapeAndSize_51((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadShear_52(HandleRef cell);

		public static double QuadShear(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadShear_52((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadShearAndSize_53(HandleRef cell);

		public static double QuadShearAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadShearAndSize_53((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadSkew_54(HandleRef cell);

		public static double QuadSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadSkew_54((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadStretch_55(HandleRef cell);

		public static double QuadStretch(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadStretch_55((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadTaper_56(HandleRef cell);

		public static double QuadTaper(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadTaper_56((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_QuadWarpage_57(HandleRef cell);

		public static double QuadWarpage(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadWarpage_57((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_RatioOff_58(HandleRef pThis);

		public virtual void RatioOff()
		{
			vtkMeshQuality.vtkMeshQuality_RatioOff_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_RatioOn_59(HandleRef pThis);

		public virtual void RatioOn()
		{
			vtkMeshQuality.vtkMeshQuality_RatioOn_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMeshQuality_SafeDownCast_60(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMeshQuality SafeDownCast(vtkObjectBase o)
		{
			vtkMeshQuality vtkMeshQuality = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMeshQuality.vtkMeshQuality_SafeDownCast_60((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMeshQuality = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMeshQuality.Register(null);
				}
			}
			return vtkMeshQuality;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SaveCellQualityOff_61(HandleRef pThis);

		public virtual void SaveCellQualityOff()
		{
			vtkMeshQuality.vtkMeshQuality_SaveCellQualityOff_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SaveCellQualityOn_62(HandleRef pThis);

		public virtual void SaveCellQualityOn()
		{
			vtkMeshQuality.vtkMeshQuality_SaveCellQualityOn_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetCompatibilityMode_63(HandleRef pThis, int cm);

		public virtual void SetCompatibilityMode(int cm)
		{
			vtkMeshQuality.vtkMeshQuality_SetCompatibilityMode_63(base.GetCppThis(), cm);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasure_64(HandleRef pThis, int _arg);

		public virtual void SetHexQualityMeasure(int _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasure_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToCondition_65(HandleRef pThis);

		public void SetHexQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToCondition_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToDiagonal_66(HandleRef pThis);

		public void SetHexQualityMeasureToDiagonal()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToDiagonal_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToDimension_67(HandleRef pThis);

		public void SetHexQualityMeasureToDimension()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToDimension_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToDistortion_68(HandleRef pThis);

		public void SetHexQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToDistortion_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToEdgeRatio_69(HandleRef pThis);

		public void SetHexQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToEdgeRatio_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToJacobian_70(HandleRef pThis);

		public void SetHexQualityMeasureToJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToJacobian_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToMaxAspectFrobenius_71(HandleRef pThis);

		public void SetHexQualityMeasureToMaxAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToMaxAspectFrobenius_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToMaxEdgeRatios_72(HandleRef pThis);

		public void SetHexQualityMeasureToMaxEdgeRatios()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToMaxEdgeRatios_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToMedAspectFrobenius_73(HandleRef pThis);

		public void SetHexQualityMeasureToMedAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToMedAspectFrobenius_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToOddy_74(HandleRef pThis);

		public void SetHexQualityMeasureToOddy()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToOddy_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToRelativeSizeSquared_75(HandleRef pThis);

		public void SetHexQualityMeasureToRelativeSizeSquared()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToRelativeSizeSquared_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToScaledJacobian_76(HandleRef pThis);

		public void SetHexQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToScaledJacobian_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToShape_77(HandleRef pThis);

		public void SetHexQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToShape_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToShapeAndSize_78(HandleRef pThis);

		public void SetHexQualityMeasureToShapeAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToShapeAndSize_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToShear_79(HandleRef pThis);

		public void SetHexQualityMeasureToShear()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToShear_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToShearAndSize_80(HandleRef pThis);

		public void SetHexQualityMeasureToShearAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToShearAndSize_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToSkew_81(HandleRef pThis);

		public void SetHexQualityMeasureToSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToSkew_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToStretch_82(HandleRef pThis);

		public void SetHexQualityMeasureToStretch()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToStretch_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToTaper_83(HandleRef pThis);

		public void SetHexQualityMeasureToTaper()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToTaper_83(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToVolume_84(HandleRef pThis);

		public void SetHexQualityMeasureToVolume()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToVolume_84(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasure_85(HandleRef pThis, int _arg);

		public virtual void SetQuadQualityMeasure(int _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasure_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToArea_86(HandleRef pThis);

		public void SetQuadQualityMeasureToArea()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToArea_86(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToAspectRatio_87(HandleRef pThis);

		public void SetQuadQualityMeasureToAspectRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToAspectRatio_87(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToCondition_88(HandleRef pThis);

		public void SetQuadQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToCondition_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToDistortion_89(HandleRef pThis);

		public void SetQuadQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToDistortion_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToEdgeRatio_90(HandleRef pThis);

		public void SetQuadQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToEdgeRatio_90(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToJacobian_91(HandleRef pThis);

		public void SetQuadQualityMeasureToJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToJacobian_91(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxAngle_92(HandleRef pThis);

		public void SetQuadQualityMeasureToMaxAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMaxAngle_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxAspectFrobenius_93(HandleRef pThis);

		public void SetQuadQualityMeasureToMaxAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMaxAspectFrobenius_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxEdgeRatios_94(HandleRef pThis);

		public void SetQuadQualityMeasureToMaxEdgeRatios()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMaxEdgeRatios_94(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMedAspectFrobenius_95(HandleRef pThis);

		public void SetQuadQualityMeasureToMedAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMedAspectFrobenius_95(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMinAngle_96(HandleRef pThis);

		public void SetQuadQualityMeasureToMinAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMinAngle_96(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToOddy_97(HandleRef pThis);

		public void SetQuadQualityMeasureToOddy()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToOddy_97(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToRadiusRatio_98(HandleRef pThis);

		public void SetQuadQualityMeasureToRadiusRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToRadiusRatio_98(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToRelativeSizeSquared_99(HandleRef pThis);

		public void SetQuadQualityMeasureToRelativeSizeSquared()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToRelativeSizeSquared_99(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToScaledJacobian_100(HandleRef pThis);

		public void SetQuadQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToScaledJacobian_100(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShape_101(HandleRef pThis);

		public void SetQuadQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToShape_101(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShapeAndSize_102(HandleRef pThis);

		public void SetQuadQualityMeasureToShapeAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToShapeAndSize_102(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShear_103(HandleRef pThis);

		public void SetQuadQualityMeasureToShear()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToShear_103(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShearAndSize_104(HandleRef pThis);

		public void SetQuadQualityMeasureToShearAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToShearAndSize_104(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToSkew_105(HandleRef pThis);

		public void SetQuadQualityMeasureToSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToSkew_105(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToStretch_106(HandleRef pThis);

		public void SetQuadQualityMeasureToStretch()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToStretch_106(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToTaper_107(HandleRef pThis);

		public void SetQuadQualityMeasureToTaper()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToTaper_107(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToWarpage_108(HandleRef pThis);

		public void SetQuadQualityMeasureToWarpage()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToWarpage_108(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetRatio_109(HandleRef pThis, int r);

		public virtual void SetRatio(int r)
		{
			vtkMeshQuality.vtkMeshQuality_SetRatio_109(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetSaveCellQuality_110(HandleRef pThis, int _arg);

		public virtual void SetSaveCellQuality(int _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetSaveCellQuality_110(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasure_111(HandleRef pThis, int _arg);

		public virtual void SetTetQualityMeasure(int _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasure_111(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectBeta_112(HandleRef pThis);

		public void SetTetQualityMeasureToAspectBeta()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToAspectBeta_112(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectFrobenius_113(HandleRef pThis);

		public void SetTetQualityMeasureToAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToAspectFrobenius_113(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectGamma_114(HandleRef pThis);

		public void SetTetQualityMeasureToAspectGamma()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToAspectGamma_114(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectRatio_115(HandleRef pThis);

		public void SetTetQualityMeasureToAspectRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToAspectRatio_115(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToCollapseRatio_116(HandleRef pThis);

		public void SetTetQualityMeasureToCollapseRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToCollapseRatio_116(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToCondition_117(HandleRef pThis);

		public void SetTetQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToCondition_117(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToDistortion_118(HandleRef pThis);

		public void SetTetQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToDistortion_118(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToEdgeRatio_119(HandleRef pThis);

		public void SetTetQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToEdgeRatio_119(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToJacobian_120(HandleRef pThis);

		public void SetTetQualityMeasureToJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToJacobian_120(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToMinAngle_121(HandleRef pThis);

		public void SetTetQualityMeasureToMinAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToMinAngle_121(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToRadiusRatio_122(HandleRef pThis);

		public void SetTetQualityMeasureToRadiusRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToRadiusRatio_122(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToRelativeSizeSquared_123(HandleRef pThis);

		public void SetTetQualityMeasureToRelativeSizeSquared()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToRelativeSizeSquared_123(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToScaledJacobian_124(HandleRef pThis);

		public void SetTetQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToScaledJacobian_124(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToShape_125(HandleRef pThis);

		public void SetTetQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToShape_125(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToShapeAndSize_126(HandleRef pThis);

		public void SetTetQualityMeasureToShapeAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToShapeAndSize_126(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToVolume_127(HandleRef pThis);

		public void SetTetQualityMeasureToVolume()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToVolume_127(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasure_128(HandleRef pThis, int _arg);

		public virtual void SetTriangleQualityMeasure(int _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasure_128(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToArea_129(HandleRef pThis);

		public void SetTriangleQualityMeasureToArea()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToArea_129(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToAspectFrobenius_130(HandleRef pThis);

		public void SetTriangleQualityMeasureToAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToAspectFrobenius_130(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToAspectRatio_131(HandleRef pThis);

		public void SetTriangleQualityMeasureToAspectRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToAspectRatio_131(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToCondition_132(HandleRef pThis);

		public void SetTriangleQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToCondition_132(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToDistortion_133(HandleRef pThis);

		public void SetTriangleQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToDistortion_133(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToEdgeRatio_134(HandleRef pThis);

		public void SetTriangleQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToEdgeRatio_134(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToMaxAngle_135(HandleRef pThis);

		public void SetTriangleQualityMeasureToMaxAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToMaxAngle_135(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToMinAngle_136(HandleRef pThis);

		public void SetTriangleQualityMeasureToMinAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToMinAngle_136(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToRadiusRatio_137(HandleRef pThis);

		public void SetTriangleQualityMeasureToRadiusRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToRadiusRatio_137(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToRelativeSizeSquared_138(HandleRef pThis);

		public void SetTriangleQualityMeasureToRelativeSizeSquared()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToRelativeSizeSquared_138(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToScaledJacobian_139(HandleRef pThis);

		public void SetTriangleQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToScaledJacobian_139(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToShape_140(HandleRef pThis);

		public void SetTriangleQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToShape_140(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToShapeAndSize_141(HandleRef pThis);

		public void SetTriangleQualityMeasureToShapeAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToShapeAndSize_141(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_SetVolume_142(HandleRef pThis, int cv);

		public virtual void SetVolume(int cv)
		{
			vtkMeshQuality.vtkMeshQuality_SetVolume_142(base.GetCppThis(), cv);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetAspectBeta_143(HandleRef cell);

		public static double TetAspectBeta(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetAspectBeta_143((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetAspectFrobenius_144(HandleRef cell);

		public static double TetAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetAspectFrobenius_144((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetAspectGamma_145(HandleRef cell);

		public static double TetAspectGamma(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetAspectGamma_145((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetAspectRatio_146(HandleRef cell);

		public static double TetAspectRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetAspectRatio_146((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetCollapseRatio_147(HandleRef cell);

		public static double TetCollapseRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetCollapseRatio_147((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetCondition_148(HandleRef cell);

		public static double TetCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetCondition_148((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetDistortion_149(HandleRef cell);

		public static double TetDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetDistortion_149((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetEdgeRatio_150(HandleRef cell);

		public static double TetEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetEdgeRatio_150((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetJacobian_151(HandleRef cell);

		public static double TetJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetJacobian_151((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetMinAngle_152(HandleRef cell);

		public static double TetMinAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetMinAngle_152((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetRadiusRatio_153(HandleRef cell);

		public static double TetRadiusRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetRadiusRatio_153((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetRelativeSizeSquared_154(HandleRef cell);

		public static double TetRelativeSizeSquared(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetRelativeSizeSquared_154((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetScaledJacobian_155(HandleRef cell);

		public static double TetScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetScaledJacobian_155((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetShape_156(HandleRef cell);

		public static double TetShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetShape_156((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetShapeandSize_157(HandleRef cell);

		public static double TetShapeandSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetShapeandSize_157((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TetVolume_158(HandleRef cell);

		public static double TetVolume(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetVolume_158((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleArea_159(HandleRef cell);

		public static double TriangleArea(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleArea_159((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleAspectFrobenius_160(HandleRef cell);

		public static double TriangleAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleAspectFrobenius_160((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleAspectRatio_161(HandleRef cell);

		public static double TriangleAspectRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleAspectRatio_161((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleCondition_162(HandleRef cell);

		public static double TriangleCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleCondition_162((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleDistortion_163(HandleRef cell);

		public static double TriangleDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleDistortion_163((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleEdgeRatio_164(HandleRef cell);

		public static double TriangleEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleEdgeRatio_164((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleMaxAngle_165(HandleRef cell);

		public static double TriangleMaxAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleMaxAngle_165((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleMinAngle_166(HandleRef cell);

		public static double TriangleMinAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleMinAngle_166((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleRadiusRatio_167(HandleRef cell);

		public static double TriangleRadiusRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleRadiusRatio_167((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleRelativeSizeSquared_168(HandleRef cell);

		public static double TriangleRelativeSizeSquared(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleRelativeSizeSquared_168((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleScaledJacobian_169(HandleRef cell);

		public static double TriangleScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleScaledJacobian_169((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleShape_170(HandleRef cell);

		public static double TriangleShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleShape_170((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMeshQuality_TriangleShapeAndSize_171(HandleRef cell);

		public static double TriangleShapeAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleShapeAndSize_171((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_VolumeOff_172(HandleRef pThis);

		public virtual void VolumeOff()
		{
			vtkMeshQuality.vtkMeshQuality_VolumeOff_172(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMeshQuality_VolumeOn_173(HandleRef pThis);

		public virtual void VolumeOn()
		{
			vtkMeshQuality.vtkMeshQuality_VolumeOn_173(base.GetCppThis());
		}
	}
}
