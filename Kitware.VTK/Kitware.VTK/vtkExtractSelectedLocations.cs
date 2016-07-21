using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectedLocations : vtkExtractSelectionBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedLocations";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectedLocations()
		{
			vtkExtractSelectedLocations.MRClassNameKey = "class vtkExtractSelectedLocations";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedLocations.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedLocations"));
		}

		public vtkExtractSelectedLocations(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedLocations_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedLocations New()
		{
			vtkExtractSelectedLocations result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedLocations.vtkExtractSelectedLocations_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedLocations)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelectedLocations() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelectedLocations.vtkExtractSelectedLocations_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedLocations_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectedLocations.vtkExtractSelectedLocations_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedLocations_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedLocations.vtkExtractSelectedLocations_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedLocations_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectedLocations NewInstance()
		{
			vtkExtractSelectedLocations result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedLocations.vtkExtractSelectedLocations_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedLocations)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedLocations_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedLocations SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedLocations vtkExtractSelectedLocations = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedLocations.vtkExtractSelectedLocations_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedLocations = (vtkExtractSelectedLocations)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedLocations.Register(null);
				}
			}
			return vtkExtractSelectedLocations;
		}
	}
}
