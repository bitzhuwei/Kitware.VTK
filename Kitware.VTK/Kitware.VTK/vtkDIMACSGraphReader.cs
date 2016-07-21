using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDIMACSGraphReader : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDIMACSGraphReader";

		public new static readonly string MRClassNameKey;

		static vtkDIMACSGraphReader()
		{
			vtkDIMACSGraphReader.MRClassNameKey = "class vtkDIMACSGraphReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDIMACSGraphReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDIMACSGraphReader"));
		}

		public vtkDIMACSGraphReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDIMACSGraphReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDIMACSGraphReader New()
		{
			vtkDIMACSGraphReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDIMACSGraphReader.vtkDIMACSGraphReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDIMACSGraphReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDIMACSGraphReader.vtkDIMACSGraphReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDIMACSGraphReader_GetEdgeAttributeArrayName_01(HandleRef pThis);

		public virtual string GetEdgeAttributeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDIMACSGraphReader.vtkDIMACSGraphReader_GetEdgeAttributeArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDIMACSGraphReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkDIMACSGraphReader.vtkDIMACSGraphReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDIMACSGraphReader_GetVertexAttributeArrayName_03(HandleRef pThis);

		public virtual string GetVertexAttributeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDIMACSGraphReader.vtkDIMACSGraphReader_GetVertexAttributeArrayName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDIMACSGraphReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDIMACSGraphReader.vtkDIMACSGraphReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDIMACSGraphReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDIMACSGraphReader.vtkDIMACSGraphReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDIMACSGraphReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDIMACSGraphReader NewInstance()
		{
			vtkDIMACSGraphReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDIMACSGraphReader.vtkDIMACSGraphReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDIMACSGraphReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDIMACSGraphReader SafeDownCast(vtkObjectBase o)
		{
			vtkDIMACSGraphReader vtkDIMACSGraphReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDIMACSGraphReader.vtkDIMACSGraphReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDIMACSGraphReader = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDIMACSGraphReader.Register(null);
				}
			}
			return vtkDIMACSGraphReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDIMACSGraphReader_SetEdgeAttributeArrayName_09(HandleRef pThis, string _arg);

		public virtual void SetEdgeAttributeArrayName(string _arg)
		{
			vtkDIMACSGraphReader.vtkDIMACSGraphReader_SetEdgeAttributeArrayName_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDIMACSGraphReader_SetFileName_10(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkDIMACSGraphReader.vtkDIMACSGraphReader_SetFileName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDIMACSGraphReader_SetVertexAttributeArrayName_11(HandleRef pThis, string _arg);

		public virtual void SetVertexAttributeArrayName(string _arg)
		{
			vtkDIMACSGraphReader.vtkDIMACSGraphReader_SetVertexAttributeArrayName_11(base.GetCppThis(), _arg);
		}
	}
}
