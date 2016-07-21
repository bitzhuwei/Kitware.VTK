using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectedPolyDataIds : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedPolyDataIds";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectedPolyDataIds()
		{
			vtkExtractSelectedPolyDataIds.MRClassNameKey = "class vtkExtractSelectedPolyDataIds";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedPolyDataIds.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedPolyDataIds"));
		}

		public vtkExtractSelectedPolyDataIds(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedPolyDataIds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedPolyDataIds New()
		{
			vtkExtractSelectedPolyDataIds result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelectedPolyDataIds() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedPolyDataIds_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedPolyDataIds_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedPolyDataIds_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectedPolyDataIds NewInstance()
		{
			vtkExtractSelectedPolyDataIds result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedPolyDataIds_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedPolyDataIds SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedPolyDataIds vtkExtractSelectedPolyDataIds = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedPolyDataIds.vtkExtractSelectedPolyDataIds_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedPolyDataIds = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedPolyDataIds.Register(null);
				}
			}
			return vtkExtractSelectedPolyDataIds;
		}
	}
}
