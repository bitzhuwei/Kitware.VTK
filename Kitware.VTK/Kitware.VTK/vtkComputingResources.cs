using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkComputingResources : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkComputingResources";

		public new static readonly string MRClassNameKey;

		static vtkComputingResources()
		{
			vtkComputingResources.MRClassNameKey = "class vtkComputingResources";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkComputingResources.MRClassNameKey, Type.GetType("Kitware.VTK.vtkComputingResources"));
		}

		public vtkComputingResources(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkComputingResources_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkComputingResources New()
		{
			vtkComputingResources result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkComputingResources.vtkComputingResources_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputingResources)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkComputingResources() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkComputingResources.vtkComputingResources_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkComputingResources_Clear_01(HandleRef pThis);

		public void Clear()
		{
			vtkComputingResources.vtkComputingResources_Clear_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkComputingResources_Collect_02(HandleRef pThis, HandleRef res);

		public void Collect(vtkComputingResources res)
		{
			vtkComputingResources.vtkComputingResources_Collect_02(base.GetCppThis(), (res == null) ? default(HandleRef) : res.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkComputingResources_Deploy_03(HandleRef pThis, HandleRef exec, HandleRef info);

		public void Deploy(vtkThreadedStreamingPipeline exec, vtkInformation info)
		{
			vtkComputingResources.vtkComputingResources_Deploy_03(base.GetCppThis(), (exec == null) ? default(HandleRef) : exec.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkComputingResources_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkComputingResources.vtkComputingResources_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkComputingResources_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkComputingResources.vtkComputingResources_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkComputingResources_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkComputingResources NewInstance()
		{
			vtkComputingResources result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkComputingResources.vtkComputingResources_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputingResources)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkComputingResources_ObtainMaximumResources_08(HandleRef pThis);

		public void ObtainMaximumResources()
		{
			vtkComputingResources.vtkComputingResources_ObtainMaximumResources_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkComputingResources_ObtainMinimumResources_09(HandleRef pThis);

		public void ObtainMinimumResources()
		{
			vtkComputingResources.vtkComputingResources_ObtainMinimumResources_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkComputingResources_Reserve_10(HandleRef pThis, HandleRef res);

		public bool Reserve(vtkComputingResources res)
		{
			return vtkComputingResources.vtkComputingResources_Reserve_10(base.GetCppThis(), (res == null) ? default(HandleRef) : res.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkComputingResources_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkComputingResources SafeDownCast(vtkObjectBase o)
		{
			vtkComputingResources vtkComputingResources = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkComputingResources.vtkComputingResources_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkComputingResources = (vtkComputingResources)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkComputingResources.Register(null);
				}
			}
			return vtkComputingResources;
		}
	}
}
