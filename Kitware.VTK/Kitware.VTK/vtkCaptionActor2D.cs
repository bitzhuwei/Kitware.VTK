using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCaptionActor2D : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionActor2D";

		public new static readonly string MRClassNameKey;

		static vtkCaptionActor2D()
		{
			vtkCaptionActor2D.MRClassNameKey = "class vtkCaptionActor2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCaptionActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionActor2D"));
		}

		public vtkCaptionActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCaptionActor2D New()
		{
			vtkCaptionActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCaptionActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCaptionActor2D.vtkCaptionActor2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_AttachEdgeOnlyOff_01(HandleRef pThis);

		public virtual void AttachEdgeOnlyOff()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_AttachEdgeOnlyOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_AttachEdgeOnlyOn_02(HandleRef pThis);

		public virtual void AttachEdgeOnlyOn()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_AttachEdgeOnlyOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_BorderOff_03(HandleRef pThis);

		public virtual void BorderOff()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_BorderOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_BorderOn_04(HandleRef pThis);

		public virtual void BorderOn()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_BorderOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetAttachEdgeOnly_05(HandleRef pThis);

		public virtual int GetAttachEdgeOnly()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetAttachEdgeOnly_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_GetAttachmentPoint_06(HandleRef pThis);

		public virtual double[] GetAttachmentPoint()
		{
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetAttachmentPoint_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_GetAttachmentPointCoordinate_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetAttachmentPointCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetAttachmentPointCoordinate_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetBorder_08(HandleRef pThis);

		public virtual int GetBorder()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetBorder_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_GetCaption_09(HandleRef pThis);

		public virtual string GetCaption()
		{
			return Marshal.PtrToStringAnsi(vtkCaptionActor2D.vtkCaptionActor2D_GetCaption_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_GetCaptionTextProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetCaptionTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetCaptionTextProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetLeader_11(HandleRef pThis);

		public virtual int GetLeader()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetLeader_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_GetLeaderGlyph_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyData GetLeaderGlyph()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetLeaderGlyph_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCaptionActor2D_GetLeaderGlyphSize_13(HandleRef pThis);

		public virtual double GetLeaderGlyphSize()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetLeaderGlyphSize_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCaptionActor2D_GetLeaderGlyphSizeMaxValue_14(HandleRef pThis);

		public virtual double GetLeaderGlyphSizeMaxValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetLeaderGlyphSizeMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCaptionActor2D_GetLeaderGlyphSizeMinValue_15(HandleRef pThis);

		public virtual double GetLeaderGlyphSizeMinValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetLeaderGlyphSizeMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSize_16(HandleRef pThis);

		public virtual int GetMaximumLeaderGlyphSize()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetMaximumLeaderGlyphSize_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMaxValue_17(HandleRef pThis);

		public virtual int GetMaximumLeaderGlyphSizeMaxValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMinValue_18(HandleRef pThis);

		public virtual int GetMaximumLeaderGlyphSizeMinValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetPadding_19(HandleRef pThis);

		public virtual int GetPadding()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetPadding_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetPaddingMaxValue_20(HandleRef pThis);

		public virtual int GetPaddingMaxValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetPaddingMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetPaddingMinValue_21(HandleRef pThis);

		public virtual int GetPaddingMinValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetPaddingMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_GetTextActor_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextActor GetTextActor()
		{
			vtkTextActor vtkTextActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetTextActor_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor.Register(null);
				}
			}
			return vtkTextActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_GetThreeDimensionalLeader_23(HandleRef pThis);

		public virtual int GetThreeDimensionalLeader()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetThreeDimensionalLeader_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_HasTranslucentPolygonalGeometry_24(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_HasTranslucentPolygonalGeometry_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_LeaderOff_27(HandleRef pThis);

		public virtual void LeaderOff()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_LeaderOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_LeaderOn_28(HandleRef pThis);

		public virtual void LeaderOn()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_LeaderOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCaptionActor2D NewInstance()
		{
			vtkCaptionActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_ReleaseGraphicsResources_31(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_ReleaseGraphicsResources_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_RenderOpaqueGeometry_32(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_RenderOpaqueGeometry_32(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_RenderOverlay_33(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_RenderOverlay_33(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCaptionActor2D_RenderTranslucentPolygonalGeometry_34(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_RenderTranslucentPolygonalGeometry_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionActor2D_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCaptionActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetAttachEdgeOnly_36(HandleRef pThis, int _arg);

		public virtual void SetAttachEdgeOnly(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetAttachEdgeOnly_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetAttachmentPoint_37(HandleRef pThis, IntPtr x);

		public virtual void SetAttachmentPoint(IntPtr x)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetAttachmentPoint_37(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetAttachmentPoint_38(HandleRef pThis, double x, double y, double z);

		public virtual void SetAttachmentPoint(double x, double y, double z)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetAttachmentPoint_38(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetBorder_39(HandleRef pThis, int _arg);

		public virtual void SetBorder(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetBorder_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetCaption_40(HandleRef pThis, string caption);

		public virtual void SetCaption(string caption)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetCaption_40(base.GetCppThis(), caption);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetCaptionTextProperty_41(HandleRef pThis, HandleRef p);

		public virtual void SetCaptionTextProperty(vtkTextProperty p)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetCaptionTextProperty_41(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetLeader_42(HandleRef pThis, int _arg);

		public virtual void SetLeader(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetLeader_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetLeaderGlyph_43(HandleRef pThis, HandleRef arg0);

		public virtual void SetLeaderGlyph(vtkPolyData arg0)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetLeaderGlyph_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetLeaderGlyphSize_44(HandleRef pThis, double _arg);

		public virtual void SetLeaderGlyphSize(double _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetLeaderGlyphSize_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetMaximumLeaderGlyphSize_45(HandleRef pThis, int _arg);

		public virtual void SetMaximumLeaderGlyphSize(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetMaximumLeaderGlyphSize_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetPadding_46(HandleRef pThis, int _arg);

		public virtual void SetPadding(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetPadding_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_SetThreeDimensionalLeader_47(HandleRef pThis, int _arg);

		public virtual void SetThreeDimensionalLeader(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetThreeDimensionalLeader_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_ShallowCopy_48(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_ShallowCopy_48(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_ThreeDimensionalLeaderOff_49(HandleRef pThis);

		public virtual void ThreeDimensionalLeaderOff()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_ThreeDimensionalLeaderOff_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCaptionActor2D_ThreeDimensionalLeaderOn_50(HandleRef pThis);

		public virtual void ThreeDimensionalLeaderOn()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_ThreeDimensionalLeaderOn_50(base.GetCppThis());
		}
	}
}
