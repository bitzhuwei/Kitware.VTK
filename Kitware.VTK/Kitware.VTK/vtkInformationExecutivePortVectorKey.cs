using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationExecutivePortVectorKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationExecutivePortVectorKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationExecutivePortVectorKey()
		{
			vtkInformationExecutivePortVectorKey.MRClassNameKey = "class vtkInformationExecutivePortVectorKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationExecutivePortVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationExecutivePortVectorKey"));
		}

		public vtkInformationExecutivePortVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef executive, int port);

		public void Append(vtkInformation info, vtkExecutive executive, int port)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationExecutivePortVectorKey_GetPorts_02(HandleRef pThis, HandleRef info);

		public IntPtr GetPorts(vtkInformation info)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_GetPorts_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInformationExecutivePortVectorKey_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInformationExecutivePortVectorKey_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInformationExecutivePortVectorKey_Length_05(HandleRef pThis, HandleRef info);

		public int Length(vtkInformation info)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Length_05(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationExecutivePortVectorKey_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationExecutivePortVectorKey NewInstance()
		{
			vtkInformationExecutivePortVectorKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationExecutivePortVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortVectorKey_Remove_07(HandleRef pThis, HandleRef info, HandleRef executive, int port);

		public void Remove(vtkInformation info, vtkExecutive executive, int port)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Remove_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortVectorKey_Remove_08(HandleRef pThis, HandleRef info);

		public override void Remove(vtkInformation info)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Remove_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortVectorKey_Report_09(HandleRef pThis, HandleRef info, HandleRef collector);

		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Report_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationExecutivePortVectorKey_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationExecutivePortVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationExecutivePortVectorKey vtkInformationExecutivePortVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortVectorKey = (vtkInformationExecutivePortVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortVectorKey.Register(null);
				}
			}
			return vtkInformationExecutivePortVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortVectorKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
