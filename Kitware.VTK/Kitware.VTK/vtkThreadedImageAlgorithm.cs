using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThreadedImageAlgorithm : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkThreadedImageAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkThreadedImageAlgorithm()
		{
			vtkThreadedImageAlgorithm.MRClassNameKey = "class vtkThreadedImageAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreadedImageAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadedImageAlgorithm"));
		}

		public vtkThreadedImageAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreads_01(HandleRef pThis);

		public virtual int GetNumberOfThreads()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetNumberOfThreads_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreadsMaxValue_02(HandleRef pThis);

		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetNumberOfThreadsMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreadsMinValue_03(HandleRef pThis);

		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetNumberOfThreadsMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedImageAlgorithm_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedImageAlgorithm_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadedImageAlgorithm_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThreadedImageAlgorithm NewInstance()
		{
			vtkThreadedImageAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedImageAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadedImageAlgorithm_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThreadedImageAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkThreadedImageAlgorithm vtkThreadedImageAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadedImageAlgorithm = (vtkThreadedImageAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadedImageAlgorithm.Register(null);
				}
			}
			return vtkThreadedImageAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedImageAlgorithm_SetNumberOfThreads_08(HandleRef pThis, int _arg);

		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetNumberOfThreads_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkThreadedImageAlgorithm_SplitExtent_09(HandleRef pThis, IntPtr splitExt, IntPtr startExt, int num, int total);

		public virtual int SplitExtent(IntPtr splitExt, IntPtr startExt, int num, int total)
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SplitExtent_09(base.GetCppThis(), splitExt, startExt, num, total);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkThreadedImageAlgorithm_ThreadedExecute_10(HandleRef pThis, HandleRef inData, HandleRef outData, IntPtr extent, int threadId);

		public virtual void ThreadedExecute(vtkImageData inData, vtkImageData outData, IntPtr extent, int threadId)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_ThreadedExecute_10(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), (outData == null) ? default(HandleRef) : outData.GetCppThis(), extent, threadId);
		}
	}
}
