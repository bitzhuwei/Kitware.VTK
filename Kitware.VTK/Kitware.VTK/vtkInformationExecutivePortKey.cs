using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationExecutivePortKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationExecutivePortKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationExecutivePortKey()
		{
			vtkInformationExecutivePortKey.MRClassNameKey = "class vtkInformationExecutivePortKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationExecutivePortKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationExecutivePortKey"));
		}

		public vtkInformationExecutivePortKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortKey_Get_01(HandleRef pThis, HandleRef info, HandleRef executive, ref int port);

		public void Get(vtkInformation info, vtkExecutive executive, ref int port)
		{
			vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis(), ref port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationExecutivePortKey_GetExecutive_02(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExecutive GetExecutive(vtkInformation info)
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_GetExecutive_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutive = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutive.Register(null);
				}
			}
			return vtkExecutive;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInformationExecutivePortKey_GetPort_03(HandleRef pThis, HandleRef info);

		public int GetPort(vtkInformation info)
		{
			return vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_GetPort_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInformationExecutivePortKey_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInformationExecutivePortKey_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationExecutivePortKey_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationExecutivePortKey NewInstance()
		{
			vtkInformationExecutivePortKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortKey_Report_07(HandleRef pThis, HandleRef info, HandleRef collector);

		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_Report_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationExecutivePortKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationExecutivePortKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationExecutivePortKey vtkInformationExecutivePortKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortKey = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortKey.Register(null);
				}
			}
			return vtkInformationExecutivePortKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortKey_Set_09(HandleRef pThis, HandleRef info, HandleRef arg1, int arg2);

		public void Set(vtkInformation info, vtkExecutive arg1, int arg2)
		{
			vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_Set_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInformationExecutivePortKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_ShallowCopy_10(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
