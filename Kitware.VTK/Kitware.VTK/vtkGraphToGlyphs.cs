using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphToGlyphs : vtkPolyDataAlgorithm
	{
		public enum CIRCLE_WrapperEnum
		{
			CIRCLE = 7,
			CROSS = 3,
			DASH = 2,
			DIAMOND = 8,
			SPHERE,
			SQUARE = 6,
			THICKCROSS = 4,
			TRIANGLE,
			VERTEX = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphToGlyphs";

		public new static readonly string MRClassNameKey;

		static vtkGraphToGlyphs()
		{
			vtkGraphToGlyphs.MRClassNameKey = "class vtkGraphToGlyphs";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphToGlyphs.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphToGlyphs"));
		}

		public vtkGraphToGlyphs(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphToGlyphs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphToGlyphs New()
		{
			vtkGraphToGlyphs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphToGlyphs.vtkGraphToGlyphs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphToGlyphs() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphToGlyphs.vtkGraphToGlyphs_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphToGlyphs_FilledOff_01(HandleRef pThis);

		public virtual void FilledOff()
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_FilledOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphToGlyphs_FilledOn_02(HandleRef pThis);

		public virtual void FilledOn()
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_FilledOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGraphToGlyphs_GetFilled_03(HandleRef pThis);

		public virtual bool GetFilled()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetFilled_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphToGlyphs_GetGlyphType_04(HandleRef pThis);

		public virtual int GetGlyphType()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetGlyphType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkGraphToGlyphs_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphToGlyphs_GetRenderer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphToGlyphs.vtkGraphToGlyphs_GetRenderer_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGraphToGlyphs_GetScaling_07(HandleRef pThis);

		public virtual bool GetScaling()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetScaling_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkGraphToGlyphs_GetScreenSize_08(HandleRef pThis);

		public virtual double GetScreenSize()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetScreenSize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphToGlyphs_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphToGlyphs_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphToGlyphs_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphToGlyphs NewInstance()
		{
			vtkGraphToGlyphs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphToGlyphs.vtkGraphToGlyphs_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphToGlyphs_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphToGlyphs SafeDownCast(vtkObjectBase o)
		{
			vtkGraphToGlyphs vtkGraphToGlyphs = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphToGlyphs.vtkGraphToGlyphs_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphToGlyphs = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphToGlyphs.Register(null);
				}
			}
			return vtkGraphToGlyphs;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphToGlyphs_SetFilled_14(HandleRef pThis, byte _arg);

		public virtual void SetFilled(bool _arg)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetFilled_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphToGlyphs_SetGlyphType_15(HandleRef pThis, int _arg);

		public virtual void SetGlyphType(int _arg)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetGlyphType_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphToGlyphs_SetRenderer_16(HandleRef pThis, HandleRef ren);

		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetRenderer_16(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphToGlyphs_SetScaling_17(HandleRef pThis, byte b);

		public virtual void SetScaling(bool b)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetScaling_17(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphToGlyphs_SetScreenSize_18(HandleRef pThis, double _arg);

		public virtual void SetScreenSize(double _arg)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetScreenSize_18(base.GetCppThis(), _arg);
		}
	}
}
