using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProbeSelectedLocations : vtkExtractSelectionBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProbeSelectedLocations";

		public new static readonly string MRClassNameKey;

		static vtkProbeSelectedLocations()
		{
			vtkProbeSelectedLocations.MRClassNameKey = "class vtkProbeSelectedLocations";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProbeSelectedLocations.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbeSelectedLocations"));
		}

		public vtkProbeSelectedLocations(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProbeSelectedLocations_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProbeSelectedLocations New()
		{
			vtkProbeSelectedLocations result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProbeSelectedLocations.vtkProbeSelectedLocations_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbeSelectedLocations)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProbeSelectedLocations() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProbeSelectedLocations.vtkProbeSelectedLocations_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProbeSelectedLocations_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProbeSelectedLocations.vtkProbeSelectedLocations_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProbeSelectedLocations_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProbeSelectedLocations.vtkProbeSelectedLocations_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProbeSelectedLocations_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProbeSelectedLocations NewInstance()
		{
			vtkProbeSelectedLocations result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProbeSelectedLocations.vtkProbeSelectedLocations_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbeSelectedLocations)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProbeSelectedLocations_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProbeSelectedLocations SafeDownCast(vtkObjectBase o)
		{
			vtkProbeSelectedLocations vtkProbeSelectedLocations = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProbeSelectedLocations.vtkProbeSelectedLocations_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProbeSelectedLocations = (vtkProbeSelectedLocations)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProbeSelectedLocations.Register(null);
				}
			}
			return vtkProbeSelectedLocations;
		}
	}
}
