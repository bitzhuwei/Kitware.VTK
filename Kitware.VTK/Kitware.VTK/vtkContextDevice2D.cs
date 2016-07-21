using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkContextDevice2D : vtkObject
	{
		public enum TextureProperty
		{
			Linear = 2,
			Nearest = 1,
			Repeat = 8,
			Stretch = 4
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkContextDevice2D";

		public new static readonly string MRClassNameKey;

		static vtkContextDevice2D()
		{
			vtkContextDevice2D.MRClassNameKey = "class vtkContextDevice2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextDevice2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextDevice2D"));
		}

		public vtkContextDevice2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_ApplyBrush_01(HandleRef pThis, HandleRef brush);

		public void ApplyBrush(vtkBrush brush)
		{
			vtkContextDevice2D.vtkContextDevice2D_ApplyBrush_01(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_ApplyPen_02(HandleRef pThis, HandleRef pen);

		public void ApplyPen(vtkPen pen)
		{
			vtkContextDevice2D.vtkContextDevice2D_ApplyPen_02(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_ApplyTextProp_03(HandleRef pThis, HandleRef prop);

		public void ApplyTextProp(vtkTextProperty prop)
		{
			vtkContextDevice2D.vtkContextDevice2D_ApplyTextProp_03(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_Begin_04(HandleRef pThis, HandleRef arg0);

		public virtual void Begin(vtkViewport arg0)
		{
			vtkContextDevice2D.vtkContextDevice2D_Begin_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_BufferIdModeEnd_05(HandleRef pThis);

		public virtual void BufferIdModeEnd()
		{
			vtkContextDevice2D.vtkContextDevice2D_BufferIdModeEnd_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DisableClipping_06(HandleRef pThis);

		public virtual void DisableClipping()
		{
			vtkContextDevice2D.vtkContextDevice2D_DisableClipping_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawEllipseWedge_07(HandleRef pThis, float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle);

		public virtual void DrawEllipseWedge(float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawEllipseWedge_07(base.GetCppThis(), x, y, outRx, outRy, inRx, inRy, startAngle, stopAngle);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawEllipticArc_08(HandleRef pThis, float x, float y, float rX, float rY, float startAngle, float stopAngle);

		public virtual void DrawEllipticArc(float x, float y, float rX, float rY, float startAngle, float stopAngle)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawEllipticArc_08(base.GetCppThis(), x, y, rX, rY, startAngle, stopAngle);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawImage_09(HandleRef pThis, IntPtr p, float scale, HandleRef image);

		public virtual void DrawImage(IntPtr p, float scale, vtkImageData image)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawImage_09(base.GetCppThis(), p, scale, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawPointSprites_10(HandleRef pThis, HandleRef sprite, IntPtr points, int n, IntPtr colors, int nc_comps);

		public virtual void DrawPointSprites(vtkImageData sprite, IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawPointSprites_10(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), points, n, colors, nc_comps);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawPoints_11(HandleRef pThis, IntPtr points, int n, IntPtr colors, int nc_comps);

		public virtual void DrawPoints(IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawPoints_11(base.GetCppThis(), points, n, colors, nc_comps);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawPoly_12(HandleRef pThis, IntPtr points, int n, IntPtr colors, int nc_comps);

		public virtual void DrawPoly(IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawPoly_12(base.GetCppThis(), points, n, colors, nc_comps);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawPolygon_13(HandleRef pThis, IntPtr arg0, int arg1);

		public virtual void DrawPolygon(IntPtr arg0, int arg1)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawPolygon_13(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawQuad_14(HandleRef pThis, IntPtr arg0, int arg1);

		public virtual void DrawQuad(IntPtr arg0, int arg1)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawQuad_14(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_DrawQuadStrip_15(HandleRef pThis, IntPtr arg0, int arg1);

		public virtual void DrawQuadStrip(IntPtr arg0, int arg1)
		{
			vtkContextDevice2D.vtkContextDevice2D_DrawQuadStrip_15(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_End_16(HandleRef pThis);

		public virtual void End()
		{
			vtkContextDevice2D.vtkContextDevice2D_End_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextDevice2D_GetBrush_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextDevice2D.vtkContextDevice2D_GetBrush_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkContextDevice2D_GetBufferIdMode_18(HandleRef pThis);

		public virtual bool GetBufferIdMode()
		{
			return vtkContextDevice2D.vtkContextDevice2D_GetBufferIdMode_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextDevice2D_GetHeight_19(HandleRef pThis);

		public virtual int GetHeight()
		{
			return vtkContextDevice2D.vtkContextDevice2D_GetHeight_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_GetMatrix_20(HandleRef pThis, HandleRef m);

		public virtual void GetMatrix(vtkMatrix3x3 m)
		{
			vtkContextDevice2D.vtkContextDevice2D_GetMatrix_20(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextDevice2D_GetPen_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextDevice2D.vtkContextDevice2D_GetPen_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkContextDevice2D_GetTextProp_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProp()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextDevice2D.vtkContextDevice2D_GetTextProp_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkContextDevice2D_GetWidth_23(HandleRef pThis);

		public virtual int GetWidth()
		{
			return vtkContextDevice2D.vtkContextDevice2D_GetWidth_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextDevice2D_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContextDevice2D.vtkContextDevice2D_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextDevice2D_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContextDevice2D.vtkContextDevice2D_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_MultiplyMatrix_26(HandleRef pThis, HandleRef m);

		public virtual void MultiplyMatrix(vtkMatrix3x3 m)
		{
			vtkContextDevice2D.vtkContextDevice2D_MultiplyMatrix_26(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextDevice2D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContextDevice2D NewInstance()
		{
			vtkContextDevice2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextDevice2D.vtkContextDevice2D_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextDevice2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_PopMatrix_28(HandleRef pThis);

		public virtual void PopMatrix()
		{
			vtkContextDevice2D.vtkContextDevice2D_PopMatrix_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_PushMatrix_29(HandleRef pThis);

		public virtual void PushMatrix()
		{
			vtkContextDevice2D.vtkContextDevice2D_PushMatrix_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextDevice2D_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextDevice2D SafeDownCast(vtkObjectBase o)
		{
			vtkContextDevice2D vtkContextDevice2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextDevice2D.vtkContextDevice2D_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkContextDevice2D_SetClipping_31(HandleRef pThis, IntPtr x);

		public virtual void SetClipping(IntPtr x)
		{
			vtkContextDevice2D.vtkContextDevice2D_SetClipping_31(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_SetColor4_32(HandleRef pThis, IntPtr color);

		public virtual void SetColor4(IntPtr color)
		{
			vtkContextDevice2D.vtkContextDevice2D_SetColor4_32(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_SetLineType_33(HandleRef pThis, int type);

		public virtual void SetLineType(int type)
		{
			vtkContextDevice2D.vtkContextDevice2D_SetLineType_33(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_SetLineWidth_34(HandleRef pThis, float width);

		public virtual void SetLineWidth(float width)
		{
			vtkContextDevice2D.vtkContextDevice2D_SetLineWidth_34(base.GetCppThis(), width);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_SetMatrix_35(HandleRef pThis, HandleRef m);

		public virtual void SetMatrix(vtkMatrix3x3 m)
		{
			vtkContextDevice2D.vtkContextDevice2D_SetMatrix_35(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_SetPointSize_36(HandleRef pThis, float size);

		public virtual void SetPointSize(float size)
		{
			vtkContextDevice2D.vtkContextDevice2D_SetPointSize_36(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextDevice2D_SetTexture_37(HandleRef pThis, HandleRef image, int properties);

		public virtual void SetTexture(vtkImageData image, int properties)
		{
			vtkContextDevice2D.vtkContextDevice2D_SetTexture_37(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), properties);
		}
	}
}
