using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageToImageFilter : vtkImageSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToImageFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageToImageFilter()
		{
			vtkImageToImageFilter.MRClassNameKey = "class vtkImageToImageFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToImageFilter"));
		}

		public vtkImageToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageToImageFilter_BypassOff_01(HandleRef pThis);

		public void BypassOff()
		{
			vtkImageToImageFilter.vtkImageToImageFilter_BypassOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageToImageFilter_BypassOn_02(HandleRef pThis);

		public void BypassOn()
		{
			vtkImageToImageFilter.vtkImageToImageFilter_BypassOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageToImageFilter_GetBypass_03(HandleRef pThis);

		public virtual int GetBypass()
		{
			return vtkImageToImageFilter.vtkImageToImageFilter_GetBypass_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToImageFilter_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToImageFilter.vtkImageToImageFilter_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageToImageFilter_GetInputMemoryLimit_05(HandleRef pThis);

		public int GetInputMemoryLimit()
		{
			return vtkImageToImageFilter.vtkImageToImageFilter_GetInputMemoryLimit_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageToImageFilter_GetNumberOfThreads_06(HandleRef pThis);

		public virtual int GetNumberOfThreads()
		{
			return vtkImageToImageFilter.vtkImageToImageFilter_GetNumberOfThreads_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageToImageFilter_GetNumberOfThreadsMaxValue_07(HandleRef pThis);

		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkImageToImageFilter.vtkImageToImageFilter_GetNumberOfThreadsMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageToImageFilter_GetNumberOfThreadsMinValue_08(HandleRef pThis);

		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkImageToImageFilter.vtkImageToImageFilter_GetNumberOfThreadsMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageToImageFilter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageToImageFilter.vtkImageToImageFilter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageToImageFilter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageToImageFilter.vtkImageToImageFilter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToImageFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageToImageFilter NewInstance()
		{
			vtkImageToImageFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToImageFilter.vtkImageToImageFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToImageFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageToImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageToImageFilter vtkImageToImageFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToImageFilter.vtkImageToImageFilter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToImageFilter = (vtkImageToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToImageFilter.Register(null);
				}
			}
			return vtkImageToImageFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageToImageFilter_SetBypass_13(HandleRef pThis, int arg0);

		public void SetBypass(int arg0)
		{
			vtkImageToImageFilter.vtkImageToImageFilter_SetBypass_13(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageToImageFilter_SetInput_14(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkImageData input)
		{
			vtkImageToImageFilter.vtkImageToImageFilter_SetInput_14(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageToImageFilter_SetInputMemoryLimit_15(HandleRef pThis, int arg0);

		public void SetInputMemoryLimit(int arg0)
		{
			vtkImageToImageFilter.vtkImageToImageFilter_SetInputMemoryLimit_15(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageToImageFilter_SetNumberOfThreads_16(HandleRef pThis, int _arg);

		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkImageToImageFilter.vtkImageToImageFilter_SetNumberOfThreads_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageToImageFilter_SplitExtent_17(HandleRef pThis, IntPtr splitExt, IntPtr startExt, int num, int total);

		public virtual int SplitExtent(IntPtr splitExt, IntPtr startExt, int num, int total)
		{
			return vtkImageToImageFilter.vtkImageToImageFilter_SplitExtent_17(base.GetCppThis(), splitExt, startExt, num, total);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageToImageFilter_ThreadedExecute_18(HandleRef pThis, HandleRef inData, HandleRef outData, IntPtr extent, int threadId);

		public virtual void ThreadedExecute(vtkImageData inData, vtkImageData outData, IntPtr extent, int threadId)
		{
			vtkImageToImageFilter.vtkImageToImageFilter_ThreadedExecute_18(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), (outData == null) ? default(HandleRef) : outData.GetCppThis(), extent, threadId);
		}
	}
}
