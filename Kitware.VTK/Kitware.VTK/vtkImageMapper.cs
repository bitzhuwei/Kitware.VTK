using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkImageMapper : vtkMapper2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapper";

		public new static readonly string MRClassNameKey;

		static vtkImageMapper()
		{
			vtkImageMapper.MRClassNameKey = "class vtkImageMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapper"));
		}

		public vtkImageMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMapper New()
		{
			vtkImageMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMapper.vtkImageMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageMapper_GetColorLevel_01(HandleRef pThis);

		public virtual double GetColorLevel()
		{
			return vtkImageMapper.vtkImageMapper_GetColorLevel_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageMapper_GetColorScale_02(HandleRef pThis);

		public double GetColorScale()
		{
			return vtkImageMapper.vtkImageMapper_GetColorScale_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageMapper_GetColorShift_03(HandleRef pThis);

		public double GetColorShift()
		{
			return vtkImageMapper.vtkImageMapper_GetColorShift_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageMapper_GetColorWindow_04(HandleRef pThis);

		public virtual double GetColorWindow()
		{
			return vtkImageMapper.vtkImageMapper_GetColorWindow_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapper_GetCustomDisplayExtents_05(HandleRef pThis);

		public virtual int[] GetCustomDisplayExtents()
		{
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_GetCustomDisplayExtents_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_GetCustomDisplayExtents_06(HandleRef pThis, IntPtr data);

		public virtual void GetCustomDisplayExtents(IntPtr data)
		{
			vtkImageMapper.vtkImageMapper_GetCustomDisplayExtents_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapper_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_GetInput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkImageMapper_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImageMapper.vtkImageMapper_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageMapper_GetRenderToRectangle_09(HandleRef pThis);

		public virtual int GetRenderToRectangle()
		{
			return vtkImageMapper.vtkImageMapper_GetRenderToRectangle_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageMapper_GetUseCustomExtents_10(HandleRef pThis);

		public virtual int GetUseCustomExtents()
		{
			return vtkImageMapper.vtkImageMapper_GetUseCustomExtents_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageMapper_GetWholeZMax_11(HandleRef pThis);

		public int GetWholeZMax()
		{
			return vtkImageMapper.vtkImageMapper_GetWholeZMax_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageMapper_GetWholeZMin_12(HandleRef pThis);

		public int GetWholeZMin()
		{
			return vtkImageMapper.vtkImageMapper_GetWholeZMin_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageMapper_GetZSlice_13(HandleRef pThis);

		public virtual int GetZSlice()
		{
			return vtkImageMapper.vtkImageMapper_GetZSlice_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageMapper_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMapper.vtkImageMapper_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageMapper_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMapper.vtkImageMapper_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapper_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMapper NewInstance()
		{
			vtkImageMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_RenderData_18(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

		public virtual void RenderData(vtkViewport arg0, vtkImageData arg1, vtkActor2D arg2)
		{
			vtkImageMapper.vtkImageMapper_RenderData_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_RenderStart_19(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public void RenderStart(vtkViewport viewport, vtkActor2D actor)
		{
			vtkImageMapper.vtkImageMapper_RenderStart_19(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_RenderToRectangleOff_20(HandleRef pThis);

		public virtual void RenderToRectangleOff()
		{
			vtkImageMapper.vtkImageMapper_RenderToRectangleOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_RenderToRectangleOn_21(HandleRef pThis);

		public virtual void RenderToRectangleOn()
		{
			vtkImageMapper.vtkImageMapper_RenderToRectangleOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMapper SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapper vtkImageMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapper.vtkImageMapper_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapper = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapper.Register(null);
				}
			}
			return vtkImageMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_SetColorLevel_23(HandleRef pThis, double _arg);

		public virtual void SetColorLevel(double _arg)
		{
			vtkImageMapper.vtkImageMapper_SetColorLevel_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_SetColorWindow_24(HandleRef pThis, double _arg);

		public virtual void SetColorWindow(double _arg)
		{
			vtkImageMapper.vtkImageMapper_SetColorWindow_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_SetCustomDisplayExtents_25(HandleRef pThis, IntPtr data);

		public virtual void SetCustomDisplayExtents(IntPtr data)
		{
			vtkImageMapper.vtkImageMapper_SetCustomDisplayExtents_25(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_SetInput_26(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkImageData input)
		{
			vtkImageMapper.vtkImageMapper_SetInput_26(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_SetRenderToRectangle_27(HandleRef pThis, int _arg);

		public virtual void SetRenderToRectangle(int _arg)
		{
			vtkImageMapper.vtkImageMapper_SetRenderToRectangle_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_SetUseCustomExtents_28(HandleRef pThis, int _arg);

		public virtual void SetUseCustomExtents(int _arg)
		{
			vtkImageMapper.vtkImageMapper_SetUseCustomExtents_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_SetZSlice_29(HandleRef pThis, int _arg);

		public virtual void SetZSlice(int _arg)
		{
			vtkImageMapper.vtkImageMapper_SetZSlice_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_UseCustomExtentsOff_30(HandleRef pThis);

		public virtual void UseCustomExtentsOff()
		{
			vtkImageMapper.vtkImageMapper_UseCustomExtentsOff_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageMapper_UseCustomExtentsOn_31(HandleRef pThis);

		public virtual void UseCustomExtentsOn()
		{
			vtkImageMapper.vtkImageMapper_UseCustomExtentsOn_31(base.GetCppThis());
		}
	}
}
