using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRendererSource : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRendererSource";

		public new static readonly string MRClassNameKey;

		static vtkRendererSource()
		{
			vtkRendererSource.MRClassNameKey = "class vtkRendererSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRendererSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererSource"));
		}

		public vtkRendererSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRendererSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRendererSource New()
		{
			vtkRendererSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRendererSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRendererSource.vtkRendererSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_DepthValuesInScalarsOff_01(HandleRef pThis);

		public virtual void DepthValuesInScalarsOff()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesInScalarsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_DepthValuesInScalarsOn_02(HandleRef pThis);

		public virtual void DepthValuesInScalarsOn()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesInScalarsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_DepthValuesOff_03(HandleRef pThis);

		public virtual void DepthValuesOff()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_DepthValuesOn_04(HandleRef pThis);

		public virtual void DepthValuesOn()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRendererSource_GetDepthValues_05(HandleRef pThis);

		public virtual int GetDepthValues()
		{
			return vtkRendererSource.vtkRendererSource_GetDepthValues_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRendererSource_GetDepthValuesInScalars_06(HandleRef pThis);

		public virtual int GetDepthValuesInScalars()
		{
			return vtkRendererSource.vtkRendererSource_GetDepthValuesInScalars_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRendererSource_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetInput()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_GetInput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkRendererSource_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkRendererSource.vtkRendererSource_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRendererSource_GetOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_GetOutput_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRendererSource_GetRenderFlag_10(HandleRef pThis);

		public virtual int GetRenderFlag()
		{
			return vtkRendererSource.vtkRendererSource_GetRenderFlag_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRendererSource_GetWholeWindow_11(HandleRef pThis);

		public virtual int GetWholeWindow()
		{
			return vtkRendererSource.vtkRendererSource_GetWholeWindow_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRendererSource_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRendererSource.vtkRendererSource_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRendererSource_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRendererSource.vtkRendererSource_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRendererSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRendererSource NewInstance()
		{
			vtkRendererSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_RenderFlagOff_16(HandleRef pThis);

		public virtual void RenderFlagOff()
		{
			vtkRendererSource.vtkRendererSource_RenderFlagOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_RenderFlagOn_17(HandleRef pThis);

		public virtual void RenderFlagOn()
		{
			vtkRendererSource.vtkRendererSource_RenderFlagOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRendererSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRendererSource SafeDownCast(vtkObjectBase o)
		{
			vtkRendererSource vtkRendererSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererSource = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererSource.Register(null);
				}
			}
			return vtkRendererSource;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_SetDepthValues_19(HandleRef pThis, int _arg);

		public virtual void SetDepthValues(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetDepthValues_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_SetDepthValuesInScalars_20(HandleRef pThis, int _arg);

		public virtual void SetDepthValuesInScalars(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetDepthValuesInScalars_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_SetInput_21(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkRenderer arg0)
		{
			vtkRendererSource.vtkRendererSource_SetInput_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_SetRenderFlag_22(HandleRef pThis, int _arg);

		public virtual void SetRenderFlag(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetRenderFlag_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_SetWholeWindow_23(HandleRef pThis, int _arg);

		public virtual void SetWholeWindow(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetWholeWindow_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_WholeWindowOff_24(HandleRef pThis);

		public virtual void WholeWindowOff()
		{
			vtkRendererSource.vtkRendererSource_WholeWindowOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererSource_WholeWindowOn_25(HandleRef pThis);

		public virtual void WholeWindowOn()
		{
			vtkRendererSource.vtkRendererSource_WholeWindowOn_25(base.GetCppThis());
		}
	}
}
