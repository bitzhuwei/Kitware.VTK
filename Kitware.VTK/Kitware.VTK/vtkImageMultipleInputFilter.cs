using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMultipleInputFilter : vtkImageSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMultipleInputFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageMultipleInputFilter()
		{
			vtkImageMultipleInputFilter.MRClassNameKey = "class vtkImageMultipleInputFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMultipleInputFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMultipleInputFilter"));
		}

		public vtkImageMultipleInputFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageMultipleInputFilter_AddInput_01(HandleRef pThis, HandleRef input);

		public virtual void AddInput(vtkImageData input)
		{
			vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_AddInput_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageMultipleInputFilter_BypassOff_02(HandleRef pThis);

		public virtual void BypassOff()
		{
			vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_BypassOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageMultipleInputFilter_BypassOn_03(HandleRef pThis);

		public virtual void BypassOn()
		{
			vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_BypassOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageMultipleInputFilter_GetBypass_04(HandleRef pThis);

		public virtual int GetBypass()
		{
			return vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_GetBypass_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMultipleInputFilter_GetInput_05(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput(int num)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_GetInput_05(base.GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImageMultipleInputFilter_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_GetInput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImageMultipleInputFilter_GetNumberOfThreads_07(HandleRef pThis);

		public virtual int GetNumberOfThreads()
		{
			return vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_GetNumberOfThreads_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageMultipleInputFilter_GetNumberOfThreadsMaxValue_08(HandleRef pThis);

		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_GetNumberOfThreadsMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageMultipleInputFilter_GetNumberOfThreadsMinValue_09(HandleRef pThis);

		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_GetNumberOfThreadsMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageMultipleInputFilter_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageMultipleInputFilter_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMultipleInputFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMultipleInputFilter NewInstance()
		{
			vtkImageMultipleInputFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMultipleInputFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageMultipleInputFilter_RemoveInput_13(HandleRef pThis, HandleRef input);

		public virtual void RemoveInput(vtkImageData input)
		{
			vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_RemoveInput_13(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMultipleInputFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMultipleInputFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageMultipleInputFilter vtkImageMultipleInputFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMultipleInputFilter = (vtkImageMultipleInputFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMultipleInputFilter.Register(null);
				}
			}
			return vtkImageMultipleInputFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageMultipleInputFilter_SetBypass_15(HandleRef pThis, int _arg);

		public virtual void SetBypass(int _arg)
		{
			vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_SetBypass_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageMultipleInputFilter_SetInput_16(HandleRef pThis, int num, HandleRef input);

		public virtual void SetInput(int num, vtkImageData input)
		{
			vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_SetInput_16(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageMultipleInputFilter_SetNumberOfThreads_17(HandleRef pThis, int _arg);

		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_SetNumberOfThreads_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageMultipleInputFilter_SplitExtent_18(HandleRef pThis, IntPtr splitExt, IntPtr startExt, int num, int total);

		public virtual int SplitExtent(IntPtr splitExt, IntPtr startExt, int num, int total)
		{
			return vtkImageMultipleInputFilter.vtkImageMultipleInputFilter_SplitExtent_18(base.GetCppThis(), splitExt, startExt, num, total);
		}
	}
}
