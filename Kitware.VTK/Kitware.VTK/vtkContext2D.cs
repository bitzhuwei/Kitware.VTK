using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContext2D : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContext2D";

		public new static readonly string MRClassNameKey;

		static vtkContext2D()
		{
			vtkContext2D.MRClassNameKey = "class vtkContext2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContext2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContext2D"));
		}

		public vtkContext2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContext2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContext2D New()
		{
			vtkContext2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContext2D.vtkContext2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContext2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContext2D.vtkContext2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_AppendTransform_01(HandleRef pThis, HandleRef transform);

		public void AppendTransform(vtkTransform2D transform)
		{
			vtkContext2D.vtkContext2D_AppendTransform_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_ApplyBrush_02(HandleRef pThis, HandleRef brush);

		public void ApplyBrush(vtkBrush brush)
		{
			vtkContext2D.vtkContext2D_ApplyBrush_02(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_ApplyId_03(HandleRef pThis, long id);

		public void ApplyId(long id)
		{
			vtkContext2D.vtkContext2D_ApplyId_03(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_ApplyPen_04(HandleRef pThis, HandleRef pen);

		public void ApplyPen(vtkPen pen)
		{
			vtkContext2D.vtkContext2D_ApplyPen_04(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_ApplyTextProp_05(HandleRef pThis, HandleRef prop);

		public void ApplyTextProp(vtkTextProperty prop)
		{
			vtkContext2D.vtkContext2D_ApplyTextProp_05(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContext2D_Begin_06(HandleRef pThis, HandleRef device);

		public bool Begin(vtkContextDevice2D device)
		{
			return vtkContext2D.vtkContext2D_Begin_06(base.GetCppThis(), (device == null) ? default(HandleRef) : device.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_BufferIdModeEnd_07(HandleRef pThis);

		public void BufferIdModeEnd()
		{
			vtkContext2D.vtkContext2D_BufferIdModeEnd_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_ComputeStringBounds_08(HandleRef pThis, string arg0, HandleRef bounds);

		public void ComputeStringBounds(string arg0, vtkPoints2D bounds)
		{
			vtkContext2D.vtkContext2D_ComputeStringBounds_08(base.GetCppThis(), arg0, (bounds == null) ? default(HandleRef) : bounds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_ComputeStringBounds_09(HandleRef pThis, string arg0, IntPtr bounds);

		public void ComputeStringBounds(string arg0, IntPtr bounds)
		{
			vtkContext2D.vtkContext2D_ComputeStringBounds_09(base.GetCppThis(), arg0, bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawArc_10(HandleRef pThis, float x, float y, float r, float startAngle, float stopAngle);

		public void DrawArc(float x, float y, float r, float startAngle, float stopAngle)
		{
			vtkContext2D.vtkContext2D_DrawArc_10(base.GetCppThis(), x, y, r, startAngle, stopAngle);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawEllipse_11(HandleRef pThis, float x, float y, float rx, float ry);

		public void DrawEllipse(float x, float y, float rx, float ry)
		{
			vtkContext2D.vtkContext2D_DrawEllipse_11(base.GetCppThis(), x, y, rx, ry);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawEllipseWedge_12(HandleRef pThis, float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle);

		public void DrawEllipseWedge(float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle)
		{
			vtkContext2D.vtkContext2D_DrawEllipseWedge_12(base.GetCppThis(), x, y, outRx, outRy, inRx, inRy, startAngle, stopAngle);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawEllipticArc_13(HandleRef pThis, float x, float y, float rX, float rY, float startAngle, float stopAngle);

		public void DrawEllipticArc(float x, float y, float rX, float rY, float startAngle, float stopAngle)
		{
			vtkContext2D.vtkContext2D_DrawEllipticArc_13(base.GetCppThis(), x, y, rX, rY, startAngle, stopAngle);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawImage_14(HandleRef pThis, float x, float y, HandleRef image);

		public void DrawImage(float x, float y, vtkImageData image)
		{
			vtkContext2D.vtkContext2D_DrawImage_14(base.GetCppThis(), x, y, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawImage_15(HandleRef pThis, float x, float y, float scale, HandleRef image);

		public void DrawImage(float x, float y, float scale, vtkImageData image)
		{
			vtkContext2D.vtkContext2D_DrawImage_15(base.GetCppThis(), x, y, scale, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawLine_16(HandleRef pThis, float x1, float y1, float x2, float y2);

		public void DrawLine(float x1, float y1, float x2, float y2)
		{
			vtkContext2D.vtkContext2D_DrawLine_16(base.GetCppThis(), x1, y1, x2, y2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawLine_17(HandleRef pThis, IntPtr p);

		public void DrawLine(IntPtr p)
		{
			vtkContext2D.vtkContext2D_DrawLine_17(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawLine_18(HandleRef pThis, HandleRef points);

		public void DrawLine(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawLine_18(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPoint_19(HandleRef pThis, float x, float y);

		public void DrawPoint(float x, float y)
		{
			vtkContext2D.vtkContext2D_DrawPoint_19(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPointSprites_20(HandleRef pThis, HandleRef sprite, HandleRef points);

		public void DrawPointSprites(vtkImageData sprite, vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_20(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPointSprites_21(HandleRef pThis, HandleRef sprite, HandleRef points, HandleRef colors);

		public void DrawPointSprites(vtkImageData sprite, vtkPoints2D points, vtkUnsignedCharArray colors)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_21(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPointSprites_22(HandleRef pThis, HandleRef sprite, IntPtr points, int n, IntPtr colors, int nc_comps);

		public void DrawPointSprites(vtkImageData sprite, IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_22(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), points, n, colors, nc_comps);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPointSprites_23(HandleRef pThis, HandleRef sprite, IntPtr points, int n);

		public void DrawPointSprites(vtkImageData sprite, IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_23(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), points, n);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPoints_24(HandleRef pThis, IntPtr x, IntPtr y, int n);

		public void DrawPoints(IntPtr x, IntPtr y, int n)
		{
			vtkContext2D.vtkContext2D_DrawPoints_24(base.GetCppThis(), x, y, n);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPoints_25(HandleRef pThis, HandleRef points);

		public void DrawPoints(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawPoints_25(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPoints_26(HandleRef pThis, IntPtr points, int n);

		public void DrawPoints(IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawPoints_26(base.GetCppThis(), points, n);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPoly_27(HandleRef pThis, IntPtr x, IntPtr y, int n);

		public void DrawPoly(IntPtr x, IntPtr y, int n)
		{
			vtkContext2D.vtkContext2D_DrawPoly_27(base.GetCppThis(), x, y, n);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPoly_28(HandleRef pThis, HandleRef points);

		public void DrawPoly(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawPoly_28(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPoly_29(HandleRef pThis, IntPtr points, int n);

		public void DrawPoly(IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawPoly_29(base.GetCppThis(), points, n);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPoly_30(HandleRef pThis, IntPtr points, int n, IntPtr colors, int nc_comps);

		public void DrawPoly(IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkContext2D.vtkContext2D_DrawPoly_30(base.GetCppThis(), points, n, colors, nc_comps);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPolygon_31(HandleRef pThis, IntPtr x, IntPtr y, int n);

		public void DrawPolygon(IntPtr x, IntPtr y, int n)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_31(base.GetCppThis(), x, y, n);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPolygon_32(HandleRef pThis, HandleRef points);

		public void DrawPolygon(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_32(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawPolygon_33(HandleRef pThis, IntPtr points, int n);

		public void DrawPolygon(IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_33(base.GetCppThis(), points, n);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawQuad_34(HandleRef pThis, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);

		public void DrawQuad(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			vtkContext2D.vtkContext2D_DrawQuad_34(base.GetCppThis(), x1, y1, x2, y2, x3, y3, x4, y4);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawQuad_35(HandleRef pThis, IntPtr p);

		public void DrawQuad(IntPtr p)
		{
			vtkContext2D.vtkContext2D_DrawQuad_35(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawQuadStrip_36(HandleRef pThis, HandleRef points);

		public void DrawQuadStrip(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawQuadStrip_36(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawQuadStrip_37(HandleRef pThis, IntPtr p, int n);

		public void DrawQuadStrip(IntPtr p, int n)
		{
			vtkContext2D.vtkContext2D_DrawQuadStrip_37(base.GetCppThis(), p, n);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawRect_38(HandleRef pThis, float x, float y, float w, float h);

		public void DrawRect(float x, float y, float w, float h)
		{
			vtkContext2D.vtkContext2D_DrawRect_38(base.GetCppThis(), x, y, w, h);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawString_39(HandleRef pThis, HandleRef point, string arg1);

		public void DrawString(vtkPoints2D point, string arg1)
		{
			vtkContext2D.vtkContext2D_DrawString_39(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawString_40(HandleRef pThis, float x, float y, string arg2);

		public void DrawString(float x, float y, string arg2)
		{
			vtkContext2D.vtkContext2D_DrawString_40(base.GetCppThis(), x, y, arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawStringRect_41(HandleRef pThis, HandleRef rect, string arg1);

		public void DrawStringRect(vtkPoints2D rect, string arg1)
		{
			vtkContext2D.vtkContext2D_DrawStringRect_41(base.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_DrawWedge_42(HandleRef pThis, float x, float y, float outRadius, float inRadius, float startAngle, float stopAngle);

		public void DrawWedge(float x, float y, float outRadius, float inRadius, float startAngle, float stopAngle)
		{
			vtkContext2D.vtkContext2D_DrawWedge_42(base.GetCppThis(), x, y, outRadius, inRadius, startAngle, stopAngle);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContext2D_End_43(HandleRef pThis);

		public bool End()
		{
			return vtkContext2D.vtkContext2D_End_43(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContext2D_FloatToInt_44(float x);

		public static int FloatToInt(float x)
		{
			return vtkContext2D.vtkContext2D_FloatToInt_44(x);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContext2D_GetBrush_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetBrush_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContext2D_GetBufferIdMode_46(HandleRef pThis);

		public bool GetBufferIdMode()
		{
			return vtkContext2D.vtkContext2D_GetBufferIdMode_46(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContext2D_GetDevice_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkContextDevice2D GetDevice()
		{
			vtkContextDevice2D vtkContextDevice2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetDevice_47(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextDevice2D = (vtkContextDevice2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextDevice2D.Register(null);
				}
			}
			return vtkContextDevice2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContext2D_GetPen_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetPen_48(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContext2D_GetTextProp_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTextProperty GetTextProp()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetTextProp_49(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContext2D_GetTransform_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTransform2D GetTransform()
		{
			vtkTransform2D vtkTransform2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetTransform_50(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform2D = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform2D.Register(null);
				}
			}
			return vtkTransform2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContext2D_IsA_51(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContext2D.vtkContext2D_IsA_51(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContext2D_IsTypeOf_52(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContext2D.vtkContext2D_IsTypeOf_52(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContext2D_NewInstance_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContext2D NewInstance()
		{
			vtkContext2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContext2D.vtkContext2D_NewInstance_54(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_PopMatrix_55(HandleRef pThis);

		public void PopMatrix()
		{
			vtkContext2D.vtkContext2D_PopMatrix_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_PushMatrix_56(HandleRef pThis);

		public void PushMatrix()
		{
			vtkContext2D.vtkContext2D_PushMatrix_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContext2D_SafeDownCast_57(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContext2D SafeDownCast(vtkObjectBase o)
		{
			vtkContext2D vtkContext2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContext2D.vtkContext2D_SafeDownCast_57((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContext2D = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContext2D.Register(null);
				}
			}
			return vtkContext2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContext2D_SetTransform_58(HandleRef pThis, HandleRef transform);

		public void SetTransform(vtkTransform2D transform)
		{
			vtkContext2D.vtkContext2D_SetTransform_58(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}
	}
}
