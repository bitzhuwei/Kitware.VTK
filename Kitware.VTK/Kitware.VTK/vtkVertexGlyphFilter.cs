using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVertexGlyphFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVertexGlyphFilter";

		public new static readonly string MRClassNameKey;

		static vtkVertexGlyphFilter()
		{
			vtkVertexGlyphFilter.MRClassNameKey = "class vtkVertexGlyphFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVertexGlyphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVertexGlyphFilter"));
		}

		public vtkVertexGlyphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexGlyphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVertexGlyphFilter New()
		{
			vtkVertexGlyphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexGlyphFilter.vtkVertexGlyphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVertexGlyphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVertexGlyphFilter.vtkVertexGlyphFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVertexGlyphFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVertexGlyphFilter.vtkVertexGlyphFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVertexGlyphFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVertexGlyphFilter.vtkVertexGlyphFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexGlyphFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVertexGlyphFilter NewInstance()
		{
			vtkVertexGlyphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexGlyphFilter.vtkVertexGlyphFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexGlyphFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVertexGlyphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVertexGlyphFilter vtkVertexGlyphFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexGlyphFilter.vtkVertexGlyphFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVertexGlyphFilter = (vtkVertexGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVertexGlyphFilter.Register(null);
				}
			}
			return vtkVertexGlyphFilter;
		}
	}
}
