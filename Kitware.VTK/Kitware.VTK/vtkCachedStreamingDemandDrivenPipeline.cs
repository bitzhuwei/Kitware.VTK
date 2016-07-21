using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCachedStreamingDemandDrivenPipeline : vtkStreamingDemandDrivenPipeline
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCachedStreamingDemandDrivenPipeline";

		public new static readonly string MRClassNameKey;

		static vtkCachedStreamingDemandDrivenPipeline()
		{
			vtkCachedStreamingDemandDrivenPipeline.MRClassNameKey = "class vtkCachedStreamingDemandDrivenPipeline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCachedStreamingDemandDrivenPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCachedStreamingDemandDrivenPipeline"));
		}

		public vtkCachedStreamingDemandDrivenPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCachedStreamingDemandDrivenPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCachedStreamingDemandDrivenPipeline New()
		{
			vtkCachedStreamingDemandDrivenPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCachedStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCachedStreamingDemandDrivenPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCachedStreamingDemandDrivenPipeline_GetCacheSize_01(HandleRef pThis);

		public virtual int GetCacheSize()
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_GetCacheSize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCachedStreamingDemandDrivenPipeline_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCachedStreamingDemandDrivenPipeline_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCachedStreamingDemandDrivenPipeline_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCachedStreamingDemandDrivenPipeline NewInstance()
		{
			vtkCachedStreamingDemandDrivenPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCachedStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCachedStreamingDemandDrivenPipeline_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCachedStreamingDemandDrivenPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkCachedStreamingDemandDrivenPipeline vtkCachedStreamingDemandDrivenPipeline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCachedStreamingDemandDrivenPipeline = (vtkCachedStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCachedStreamingDemandDrivenPipeline.Register(null);
				}
			}
			return vtkCachedStreamingDemandDrivenPipeline;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCachedStreamingDemandDrivenPipeline_SetCacheSize_07(HandleRef pThis, int size);

		public void SetCacheSize(int size)
		{
			vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_SetCacheSize_07(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCachedStreamingDemandDrivenPipeline_Update_08(HandleRef pThis);

		public override int Update()
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_Update_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCachedStreamingDemandDrivenPipeline_Update_09(HandleRef pThis, int port);

		public override int Update(int port)
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_Update_09(base.GetCppThis(), port);
		}
	}
}
